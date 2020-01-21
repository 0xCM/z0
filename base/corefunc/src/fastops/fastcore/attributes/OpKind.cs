//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;

    public class OpAttribute : Attribute
    {
        public OpAttribute()
        {
            this.Name = string.Empty;
        }

        public OpAttribute(string name)
        {
            this.Name = name;
        }

        public string Name {get;}

        public override string ToString()
            => Name;
    }

    public abstract class OpKindAttribute : OpAttribute
    {
        protected OpKindAttribute(uint id, string name)
            : base(name)        
        {
            this.Id = id;
        }

        public abstract string KindName {get;}
        
        public uint Id {get;}
        

    }

    public class UnaryBitwiseOpAttribute : OpKindAttribute
    {
        static readonly string kindName = typeof(UnaryBitwiseOpKind).DisplayName();

        public UnaryBitwiseOpAttribute(UnaryBitwiseOpKind kind)
            : base((uint)kind,kind.Format())
        {
            this.Kind = kind;
        }

        public UnaryBitwiseOpKind Kind {get;}

        public override string KindName 
            => kindName;

    }


    public class BinaryBitwiseOpAttribute : OpKindAttribute
    {
        static readonly string kindName = typeof(BinaryBitwiseOpAttribute).DisplayName();

        public BinaryBitwiseOpAttribute(BinaryBitwiseOpKind kind)
            : base((uint)kind,kind.Format())
        {
            this.Kind = kind;
        }

        public BinaryBitwiseOpKind Kind {get;}

        public override string KindName => kindName;

    }


    public class BinaryLogicOpAttribute : OpKindAttribute
    {
        static readonly string kindName = typeof(BinaryBitLogicKind).DisplayName();

        public BinaryLogicOpAttribute(BinaryBitLogicKind kind)
            : base((uint)kind,kind.Format())
        {
            this.Kind = kind;
        }

        public BinaryBitLogicKind Kind {get;}

        public override string KindName 
            => kindName;

    }

    public class ComparisonOpAttribute : OpKindAttribute
    {
        static readonly string kindName = typeof(ComparisonKind).DisplayName();

        public ComparisonOpAttribute(ComparisonKind kind)
            : base((uint)kind,kind.Format())
        {
            this.Kind = kind;
        }

        public ComparisonKind Kind {get;}

        public override string KindName => kindName;
    }   
}