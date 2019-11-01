//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;

    public abstract class OpAttribute : Attribute
    {
        protected OpAttribute(uint opId, string opName)        
        {
            this.OpId = opId;
            this.OpName = opName;
        }

        public abstract string KindName {get;}
        
        public uint OpId {get;}

        public string OpName {get;}

    }

    public class UnaryBitwiseOpAttribute : OpAttribute
    {
        static readonly string kindName = typeof(UnaryBitwiseOpKind).DisplayName();

        public UnaryBitwiseOpAttribute(UnaryBitwiseOpKind kind)
            : base((uint)kind,kind.Format())
        {
            this.Kind = kind;
        }

        public UnaryBitwiseOpKind Kind {get;}

        public override string KindName => kindName;


    }

    public class BinaryBitwiseOpAttribute : OpAttribute
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

    public class TernaryOpAttribute : OpAttribute
    {
        static readonly string kindName = typeof(TernaryOpKind).DisplayName();
        
        public TernaryOpAttribute(TernaryOpKind kind)
            : base( (uint)kind,kind.Format())
        {
            this.Kind = kind;
        }

        public TernaryOpKind Kind {get;}

        public override string KindName => kindName;        
    }


    public class BinaryLogicOpAttribute : OpAttribute
    {
        static readonly string kindName = typeof(BinaryLogicOpKind).DisplayName();

        public BinaryLogicOpAttribute(BinaryLogicOpKind kind)
            : base((uint)kind,kind.Format())
        {
            this.Kind = kind;
        }

        public BinaryLogicOpKind Kind {get;}

        public override string KindName => kindName;

    }

    public class ComparisonOpAttribute : OpAttribute
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

    public class ShiftOpAttribute : OpAttribute
    {
        static readonly string kindName = typeof(ShiftOpKind).DisplayName();

        public ShiftOpAttribute(ShiftOpKind kind)
            : base((uint)kind,kind.Format())
        {
            this.Kind = kind;
        }

        public ShiftOpKind Kind {get;}

        public override string KindName => kindName;


    }


}