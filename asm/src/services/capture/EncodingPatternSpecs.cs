//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;
    using static zfunc;

    using static Z0.EncodingPatternTokens;
    using static Z0.EncodingPatternKind;
    using PK = Z0.EncodingPatternKind;

    public interface IDataPattern
    {
        bool IsPartial {get;}    
    }

    public interface IExplicitDataPattern : IDataPattern
    {
        bool IDataPattern.IsPartial => false;

    }    

    public interface IPartialDataPattern : IDataPattern
    {
        bool IDataPattern.IsPartial => true;
        
    }    

    public interface IDataPattern<T> : IDataPattern
    {
        ReadOnlySpan<T> PatternData {get;}
        
    }

    public interface IDataPattern<E,T> : IDataPattern<T>
        where E : unmanaged, Enum
    {
        
        
    }

    public interface IExplicitDataPattern<T> : IExplicitDataPattern, IDataPattern<T>
        where T : unmanaged
    {
    }

    public interface IExplicitDataPattern<E,T> : IExplicitDataPattern<T>, IDataPattern<E,T>
        where E : unmanaged, Enum
        where T : unmanaged
    {
    }

    public interface IPartialDataPattern<T>  : IPartialDataPattern, IDataPattern<T?>
        where T : unmanaged
    {
        
    }

    public interface IPartialDataPattern<E,T>  : IPartialDataPattern<T>, IDataPattern<E,T?>
        where E : unmanaged, Enum
        where T : unmanaged
    {
        
    }

    public interface IEncodingPattern : IDataPattern
    {
        EncodingPatternKind PatternKind {get;}
    }
    
    public interface IExplicitEncodingPattern : IEncodingPattern, IExplicitDataPattern<EncodingPatternKind, byte>
    {

    }

    public interface IExplicitEncodingPattern<X> : IExplicitEncodingPattern
        where X : struct, IExplicitEncodingPattern<X>     
    {

    }

    public interface IPartialEncodingPattern : IEncodingPattern, IPartialDataPattern<EncodingPatternKind, byte>
    {
        
    }

    public interface IPartialEncodingPattern<X> : IPartialEncodingPattern
        where X : struct, IPartialEncodingPattern<X>     
    {
        
    }
        
    public readonly struct EncodingPatternSpecs
    {

        EncodingPatternSpecs(int dummy)
        {
            SupportedPatterns = PatternIndex.Keys.ToArray();
        }
        public readonly PK[] SupportedPatterns;

        readonly struct RET_SBB : IExplicitEncodingPattern<RET_SBB>
        {
            public EncodingPatternKind PatternKind => CTC_RET_SBB;
            
            public ReadOnlySpan<byte> PatternData
                => new byte[]{RET, SBB};
        }

        readonly struct RET_INTR : IExplicitEncodingPattern<RET_INTR>
        {
            public EncodingPatternKind PatternKind => CTC_RET_INTR;

            public ReadOnlySpan<byte> PatternData
                => new byte[]{RET,INTR};
        }

        readonly struct RET_ZED_SBB : IExplicitEncodingPattern<RET_ZED_SBB>
        {
            public EncodingPatternKind PatternKind => CTC_RET_ZED_SBB;

            public ReadOnlySpan<byte> PatternData
                => new byte[]{RET,ZED,SBB};
        }

        readonly struct RET_Zx2 : IExplicitEncodingPattern<RET_Zx2>
        {
            public EncodingPatternKind PatternKind => CTC_RET_Zx3;

            public ReadOnlySpan<byte> PatternData
                => new byte[]{RET,ZED,ZED};
        }

        readonly struct INTRx2 : IExplicitEncodingPattern<INTRx2>
        {
            public EncodingPatternKind PatternKind => CTC_INTRx2;

            public ReadOnlySpan<byte> PatternData
                => new byte[]{INTR,INTR};
        }

        readonly struct JMP_RAX : IExplicitEncodingPattern<JMP_RAX>
        {
            public EncodingPatternKind PatternKind => CTC_JMP_RAX;

            public ReadOnlySpan<byte> PatternData
                => new byte[]{ZED,ZED,J48,FF,E0};
        }

        readonly struct Zx7 : IExplicitEncodingPattern<Zx7>
        {
            public EncodingPatternKind PatternKind => CTC_Zx7;

            public ReadOnlySpan<byte> PatternData
                => new byte[]{ZED,ZED,ZED,ZED,ZED,ZED,ZED};
        }

        readonly struct CALL32_INTR : IPartialEncodingPattern<CALL32_INTR>
        {

            public EncodingPatternKind PatternKind => CTC_CALL32_INTR;

            public ReadOnlySpan<byte?> PatternData
                => new byte?[]{CALL,null,null,null,null,INTR};            
        }

        readonly struct Empty : IExplicitEncodingPattern<Empty>
        {
            public EncodingPatternKind PatternKind => 0;

            public ReadOnlySpan<byte> PatternData
                => new byte[]{};        
        }

        readonly struct EmptyPartial : IPartialEncodingPattern<EmptyPartial>
        {
            public EncodingPatternKind PatternKind => 0;

            public ReadOnlySpan<byte?> PatternData
                => new byte?[]{};        
        }            

        static readonly Dictionary<PK,IEncodingPattern> PatternIndex
            = new Dictionary<PK, IEncodingPattern>()
                {
                    [PK.CTC_CALL32_INTR] = default(CALL32_INTR),
                    [PK.CTC_INTRx2] = default(INTRx2),
                    [PK.CTC_JMP_RAX] = default(JMP_RAX),
                    [PK.CTC_RET_INTR] = default(RET_INTR),
                    [PK.CTC_RET_SBB] = default(RET_SBB),
                    [PK.CTC_RET_ZED_SBB] = default(RET_ZED_SBB),
                    [PK.CTC_RET_Zx3] = default(RET_Zx2),
                    [PK.CTC_Zx7] = default(Zx7)
                };

    }
}