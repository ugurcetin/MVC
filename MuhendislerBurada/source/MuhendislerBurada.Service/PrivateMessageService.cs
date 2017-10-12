using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MuhendislerBurada.Model.Models;
using System.Threading.Tasks;
using MuhendislerBurada.Data.Infrastructure;
using MuhendislerBurada.Data.Repository;

namespace MuhendislerBurada.Service {
    public interface IPrivateMessageService {

        void SendMessage(string senderId, string receiverId, string message);

        void DeleteSentMessage(string userId, string partipiciantUsername);

        void DeleteReceivedMessage(string userId, string partipiciantUsername);

        IEnumerable<string> GetParticipants(string userId);
        IEnumerable<PrivateMessage> GetConversation(string userId, string partipiciantUsername);

        void SavePrivateMessages();
    }

    public class PrivateMessageService : IPrivateMessageService {

        private readonly IPrivateMessageRepository privateMessageRepository;
        private readonly IUserRepository userRepository;
        private readonly IUnitOfWork unitOfWork;
        
        public PrivateMessageService(IUserRepository userRepository, IPrivateMessageRepository privateMessageRepository, IUnitOfWork unitOfWork) {
            
            this.privateMessageRepository = privateMessageRepository;
            this.unitOfWork = unitOfWork;
            this.userRepository = userRepository;

        }

        public void DeleteReceivedMessage(string userId, string partipiciantUsername) {
            
            var partipiciant = userRepository.Get(u => u.UserName == partipiciantUsername);

            var message = privateMessageRepository.Get(m => m.SenderUserId == partipiciant.Id && m.ReceiverUserId == userId);

            privateMessageRepository.Update(message);

            SavePrivateMessages();
        }

        public void DeleteSentMessage(string userId, string partipiciantUsername) {
            
            var partipiciant = userRepository.Get(u => u.UserName == partipiciantUsername);

            var message = privateMessageRepository.Get(m => m.SenderUserId == userId && m.ReceiverUserId == partipiciant.Id);

            privateMessageRepository.Update(message);

            SavePrivateMessages();
        }

        public IEnumerable<string> GetParticipants(string userId) {
            
            // gonderilmis mesajlar karsidaki kisi ID lerini aliyoriz
            var conversations = privateMessageRepository.GetMany(m => m.SenderUserId == userId).Select(m => m.ReceiverUserId).ToList();
            // alinan mesajlar karsidaki gonderen kis ID lerini aliyoruz
            conversations.AddRange(privateMessageRepository.GetMany(m => m.ReceiverUserId == userId).Select(m => m.SenderUserId));

            return conversations.Distinct();

        }

        public IEnumerable<PrivateMessage> GetConversation(string userId, string partipiciantUsername) {
            
            var partipiciant = userRepository.Get(u => u.UserName == partipiciantUsername);

            return privateMessageRepository.GetMany(m => 
                (m.SenderUserId == userId && m.ReceiverUserId == partipiciant.Id) ||
                (m.SenderUserId == partipiciant.Id && m.ReceiverUserId == userId));

        }

        public void SendMessage(string userId, string receiverUsername, string message) {

            var receiverUser = userRepository.Get(u => u.UserName == receiverUsername);

            // @TODO kullanici varmi diye kontrol etmek lazim ama nerde ?

            privateMessageRepository.Add(new PrivateMessage {
                SenderUserId = userId,
                ReceiverUserId = receiverUser.Id,
                Message = message
            });

            SavePrivateMessages();
        }

        public void SavePrivateMessages() {

            unitOfWork.Commit();
            
        }
    }
}
