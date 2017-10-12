﻿using System.ComponentModel;

namespace MuhendislerBurada.Service
{
    public enum GroupFilter
    {
        [Description("All")]
        All,

        [Description("My Groups")]
        MyGroups,

        [Description("My Followings Groups")]
        MyFollowingsGroups,

        [Description("My Followed Groups")]
        MyFollowedGroups
    }
}
