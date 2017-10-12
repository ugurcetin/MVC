using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MuhendislerBurada.Model.Models;
namespace MuhendislerBurada.Data.Configuration
{
    public class PrivateMessageConfiguration:EntityTypeConfiguration<PrivateMessage>
    {
        public PrivateMessageConfiguration()
        {
            Property(e => e.ReceiverUserId).IsRequired();
            Property(e => e.SenderUserId).IsRequired();
            Property(e => e.Message).HasMaxLength(100);
        }
    }
}
