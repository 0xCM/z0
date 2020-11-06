//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Diagnostics;

    using static Konst;

    public interface ICmdObserver
    {

        void OnInfo(string data);


        void OnError(string data);
    }
}