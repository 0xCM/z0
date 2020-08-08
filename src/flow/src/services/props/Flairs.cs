//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct Flow    
    {
        public const AppMsgColor ErrorFlair = Flairs.Error;

        public const AppMsgColor CreatedFlair = Flairs.Created;

        public const AppMsgColor RunningFlair = Flairs.Running;

        public const AppMsgColor RanFlair = Flairs.Ran;

        public const AppMsgColor FinishedFlair = Flairs.Finished;

        public const AppMsgColor StatusFlair = Flairs.Status;   

        public const AppMsgColor InitializingFlair = Flairs.Initializing;

        public const AppMsgColor InitializedFlair = Flairs.Initialized;
    }
}