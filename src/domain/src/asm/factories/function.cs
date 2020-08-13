//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct function
    {        
        public readonly asci32 Name;

        public readonly EncodedCommand[] Commands;

        [MethodImpl(Inline)]
        public function(asci32 name, EncodedCommand[] commands)
        {
            Name = name;
            Commands = commands;
        }        

        public ref EncodedCommand this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Commands[index];
        }

        [MethodImpl(Inline)]
        public function(asci32 name)
        {
            Name = name;
            Commands = new EncodedCommand[]{};
        }        

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Commands.Length == 0;
        }
        
        public static function Empty 
        {
            [MethodImpl(Inline)]
            get => new function(asci.Null);
        }
    }
}