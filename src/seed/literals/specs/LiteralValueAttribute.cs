//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Seed;

    // /// <summary>
    // /// Attaches a literal value to a target
    // /// </summary>
    // public class LiteralValueAttribute : Attribute, ILiteralSource<LiteralValue>
    // {        
    //     [MethodImpl(Inline)]
    //     public static bool Attached(MemberInfo target)
    //         => Attribute.IsDefined(target, typeof(LiteralValueAttribute));

    //     public LiteralValue Value {get;}
        
    //     public LiteralValueAttribute(Enum value)
    //         => Value = (string.Empty,value);
        
    //     public LiteralValueAttribute(byte value)
    //         => Value = (string.Empty,value);

    //     public LiteralValueAttribute(sbyte value)
    //         => Value = (string.Empty,value);

    //     public LiteralValueAttribute(short value)
    //         => Value = (string.Empty,value);

    //     public LiteralValueAttribute(ushort value)
    //         => Value = (string.Empty,value);

    //     public LiteralValueAttribute(int value)
    //         => Value = (string.Empty,value);

    //     public LiteralValueAttribute(uint value)
    //         => Value = (string.Empty,value);

    //     public LiteralValueAttribute(long value)
    //         => Value = (string.Empty,value);

    //     public LiteralValueAttribute(ulong value)
    //         => Value = (string.Empty,value);

    //     public LiteralValueAttribute(float value)
    //         => Value = (string.Empty,value);

    //     public LiteralValueAttribute(double value)
    //         => Value = LiteralValue.Define()

    //     public LiteralValueAttribute(decimal value)
    //         => Value = (string.Empty,value);

    //     public LiteralValueAttribute(char value)
    //         => Value = (string.Empty,value);

    //     public LiteralValueAttribute(string value, bool multi = false)        
    //         => Value = new LiteralValue(string.Empty, value, multi);
        
    //     public LiteralValueAttribute(bool value)
    //         => Value = (string.Empty,value);
    // }
}