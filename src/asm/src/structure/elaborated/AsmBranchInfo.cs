//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using Z0;
    using static Seed;

    public interface IAsmBranch
    {
        MemoryAddress Base {get;}

        MemoryAddress IP {get;}

        MemoryAddress Target {get;}

        int Size {get;}

        bool IsEmpty {get;}

        bool IsNonEmpty {get;}

        bool IsNear {get;}

        //LocalAddress Local  => LocalAddress.Empty;

    }

    public readonly struct AsmNearBranch : IAsmBranch
    {
        public static AsmBranchInfo Empty => default(AsmBranchInfo);

        public MemoryAddress Base {get;}

        public MemoryAddress IP {get;}

        readonly MemoryAddress UnmodifiedTarget;
        
        public MemoryAddress Target {get;}
        

        //public LocalAddress Local {get;}

        public int Size {get;}

        public bool IsNear => true;

        [MethodImpl(Inline)]
        public static AsmNearBranch Define(MemoryAddress @base, MemoryAddress ip, MemoryAddress target, int size)
            => new AsmNearBranch(@base, ip, target, size);

        [MethodImpl(Inline)]
        internal AsmNearBranch(MemoryAddress @base, MemoryAddress ip, MemoryAddress target, int size)
        {
            Base = @base;
            IP = ip;
            UnmodifiedTarget = target;
            Target = target - @base;
            //Local = LocalAddress.From((ushort)(target - @base));
            Size = size;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Base == 0 && IP == 0 && Size == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }
    }
    
    public readonly struct AsmFarBranch : IAsmBranch
    {
        public static AsmFarBranch Empty => default(AsmFarBranch);

        public MemoryAddress Base {get;}

        public MemoryAddress IP {get;}

        public MemoryAddress Target {get;}

        public int Size {get;}

        public bool IsNear => false;

        [MethodImpl(Inline)]
        public static AsmFarBranch Define(MemoryAddress @base, MemoryAddress ip, MemoryAddress target, int size)
            => new AsmFarBranch(@base, ip, target, size);

        [MethodImpl(Inline)]
        internal AsmFarBranch(MemoryAddress @base, MemoryAddress ip, MemoryAddress target, int size)
        {
            Base = @base;
            IP = ip;
            Target = target;
            Size = size;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Base == 0 && IP == 0 && Size == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }
    }

    /// <summary>
    /// Describes a branching instruction operand
    /// </summary>
    public readonly struct AsmBranchInfo
    {

        public readonly MemoryAddress Base;

        public readonly MemoryAddress IP;

        public readonly MemoryAddress Local;

        public readonly LocalAddress Relative;

        public readonly int Size;

        public readonly bool Near;

        [MethodImpl(Inline)]
        public static AsmBranchInfo Define(MemoryAddress @base, MemoryAddress target, MemoryAddress local, int size, bool near)
            => new AsmBranchInfo(@base, target, local, size, near);

        [MethodImpl(Inline)]
        AsmBranchInfo(MemoryAddress @base, MemoryAddress target, MemoryAddress local,  int size, bool near)
        {
            Base = @base;
            IP = target;
            Local = local;
            Relative = near ? LocalAddress.From((ushort)(local - @base)) : LocalAddress.Empty;
            Size = size;
            Near = near;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Base == 0 && IP == 0 && Size == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }
    }
}