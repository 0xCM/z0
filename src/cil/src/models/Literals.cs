//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly partial struct Cil
    {
        //
        // Summary:
        //     Describes how values are pushed onto a stack or popped off a stack.
        public enum StackBehaviour : byte
        {
            //
            // Summary:
            //     No values are popped off the stack.
            Pop0,
            //
            // Summary:
            //     Pops one value off the stack.
            Pop1,
            //
            // Summary:
            //     Pops 1 value off the stack for the first operand, and 1 value of the stack for
            //     the second operand.
            Pop1_pop1,
            //
            // Summary:
            //     Pops a 32-bit integer off the stack.
            Popi,
            //
            // Summary:
            //     Pops a 32-bit integer off the stack for the first operand, and a value off the
            //     stack for the second operand.
            Popi_pop1,
            //
            // Summary:
            //     Pops a 32-bit integer off the stack for the first operand, and a 32-bit integer
            //     off the stack for the second operand.
            Popi_popi,
            //
            // Summary:
            //     Pops a 32-bit integer off the stack for the first operand, and a 64-bit integer
            //     off the stack for the second operand.
            Popi_popi8,
            //
            // Summary:
            //     Pops a 32-bit integer off the stack for the first operand, a 32-bit integer off
            //     the stack for the second operand, and a 32-bit integer off the stack for the
            //     third operand.
            Popi_popi_popi,
            //
            // Summary:
            //     Pops a 32-bit integer off the stack for the first operand, and a 32-bit floating
            //     point number off the stack for the second operand.
            Popi_popr4,
            //
            // Summary:
            //     Pops a 32-bit integer off the stack for the first operand, and a 64-bit floating
            //     point number off the stack for the second operand.
            Popi_popr8,
            //
            // Summary:
            //     Pops a reference off the stack.
            Popref,
            //
            // Summary:
            //     Pops a reference off the stack for the first operand, and a value off the stack
            //     for the second operand.
            Popref_pop1,
            //
            // Summary:
            //     Pops a reference off the stack for the first operand, and a 32-bit integer off
            //     the stack for the second operand.
            Popref_popi,
            //
            // Summary:
            //     Pops a reference off the stack for the first operand, a value off the stack for
            //     the second operand, and a value off the stack for the third operand.
            Popref_popi_popi,
            //
            // Summary:
            //     Pops a reference off the stack for the first operand, a value off the stack for
            //     the second operand, and a 64-bit integer off the stack for the third operand.
            Popref_popi_popi8,
            //
            // Summary:
            //     Pops a reference off the stack for the first operand, a value off the stack for
            //     the second operand, and a 32-bit integer off the stack for the third operand.
            Popref_popi_popr4,
            //
            // Summary:
            //     Pops a reference off the stack for the first operand, a value off the stack for
            //     the second operand, and a 64-bit floating point number off the stack for the
            //     third operand.
            Popref_popi_popr8,
            //
            // Summary:
            //     Pops a reference off the stack for the first operand, a value off the stack for
            //     the second operand, and a reference off the stack for the third operand.
            Popref_popi_popref,
            //
            // Summary:
            //     No values are pushed onto the stack.
            Push0,
            //
            // Summary:
            //     Pushes one value onto the stack.
            Push1,
            //
            // Summary:
            //     Pushes 1 value onto the stack for the first operand, and 1 value onto the stack
            //     for the second operand.
            Push1_push1,
            //
            // Summary:
            //     Pushes a 32-bit integer onto the stack.
            Pushi,
            //
            // Summary:
            //     Pushes a 64-bit integer onto the stack.
            Pushi8,
            //
            // Summary:
            //     Pushes a 32-bit floating point number onto the stack.
            Pushr4,
            //
            // Summary:
            //     Pushes a 64-bit floating point number onto the stack.
            Pushr8,
            //
            // Summary:
            //     Pushes a reference onto the stack.
            Pushref,
            //
            // Summary:
            //     Pops a variable off the stack.
            Varpop,
            //
            // Summary:
            //     Pushes a variable onto the stack.
            Varpush,
            //
            // Summary:
            //     Pops a reference off the stack for the first operand, a value off the stack for
            //     the second operand, and a 32-bit integer off the stack for the third operand.
            Popref_popi_pop1
        }
    }
}