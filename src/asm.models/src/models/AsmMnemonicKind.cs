//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct MnemonicNames
    {
        public const string and = nameof(and);

        public const string movsx = nameof(movsx);

        public const string jg = nameof(jg);        
    }

    public interface IMnemonicKind
    {        
        string Name {get;}   
        
    }
    
    public interface IMnemonicKind<K> : IMnemonicKind
        where K : struct, IMnemonicKind<K>
    {
        
    }
    
    public readonly struct MnemonicKind<K> : IMnemonicKind<K>
        where K : struct, IMnemonicKind<K>    
    {
        readonly K Kind;

        public string Name => Kind.Name;        
    }

    public readonly struct MnemonicKinds
    {
        public readonly struct AND : IMnemonicKind<AND>
        {
            public string Name => MnemonicNames.and;
        }
    }
}