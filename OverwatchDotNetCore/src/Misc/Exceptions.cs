﻿using System;

namespace OverwatchAPICore.Internal
{
    class UserRegionNotDefinedException : Exception
    {
        public UserRegionNotDefinedException() : base("OverwatchPlayer Region is not defined. Use 'DetectRegion()' or set the Region in the constructor.") { }
    }

    class InvalidBattletagException : Exception
    {
        public InvalidBattletagException() : base("OverwatchPlayer's Battletag is not valid - Format is 'User#1234`") { }
    }

    class UserProfileUrlNullException : Exception
    {
        public UserProfileUrlNullException() : base("OverwatchPlayer's profile URL has not been set - If no region/URL was entered when constructing the OverwatchPlayer then use 'player.DetectRegionPC();'") { }
    }

    class UserPlatformNotDefinedException : Exception
    {
        public UserPlatformNotDefinedException() : base("User's platform has not been defined - If no Platform was entered when constructing the OverwatchPlayer then use 'player.DetectPlatform();'") { }
    }
}
