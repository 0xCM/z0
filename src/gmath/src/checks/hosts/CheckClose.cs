//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct CheckClose : TCheckClose
    {
        public static TCheckClose Checker => default(CheckClose);

        internal const double Tolerance = .1;

        internal const float Res32 = .0000001f;
        
        internal const double Res64 = .0000001;
    }
}