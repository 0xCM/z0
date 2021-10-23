//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static AsciLetterLoSym;

    using A = AsciLetterLoSym;

    public enum Token26 : byte
    {
        None = 0,

        Dog,

        Cat,

        Fox,

        Hound,

        Chicken,
    }

    [ApiHost]
    public struct Dfa26
    {
        byte Depth;

        Token26 Token;

        // dog
        // cat
        // fox
        // hound
        // chicken

        public static Dfa26 create()
            => default;

        // (0,'d'), (1,'o'), (2,'g')
        // (0,'c'), (1,'a'), (2,'t')
        // (0,'f'), (1,'o'), (2,'x')
        // (0,'h'), (1,'o'), (2,'u), (3, 'n'), (4, 'd')
        // (0,'c'), (1,'h'), (2,'i'), (3,'c'), (4,'k'), (5,'e'), (6,'n')

        [Op]
        public Token26 Process(ReadOnlySpan<char> src)
        {
            Depth = 0;
            Token = 0;
            var count = src.Length;
            var accepted = false;
            for(var i=0; i<count; i++)
            {
                ref readonly var a = ref skip(src,i);
                accepted = Match((A)a);
                if(!accepted)
                    break;
            }
            return Token;
        }

        [Op]
        bool Match(A input)
        {
            var accepted = false;
            switch(input)
            {
                case a:
                {
                    switch(Depth)
                    {
                        // c(a)t
                        case 1:
                            accepted = true;
                            Depth++;
                        break;
                    }
                }
                break;
                case b:
                {
                    switch(Depth)
                    {
                        default:
                            accepted = false;
                            Depth = 0;
                        break;
                    }
                }
                break;
                case c:
                {
                    switch(Depth)
                    {
                        // (c)at, (c)hicken
                        case 0:
                            accepted = true;
                            Depth++;
                        break;
                        // chi(c)ken
                        case 3:
                            accepted = true;
                            Depth++;
                        break;
                    }
                }
                break;
                case d:
                {
                    switch(Depth)
                    {
                        // (d)og
                        case 0:
                            accepted = true;
                            Depth++;
                        break;
                        // houn(d)
                        case 4:
                            accepted = true;
                            Depth++;
                            Token = Token26.Hound;
                        break;
                    }
                }
                break;
                case e:
                {
                    switch(Depth)
                    {
                        // chick(e)n
                        case 5:
                            accepted = true;
                            Depth++;
                        break;
                    }
                }
                break;
                case f:
                {
                    switch(Depth)
                    {
                        // (f)ox
                        case 0:
                            accepted = true;
                            Depth++;
                        break;
                    }
                }
                break;
                case g:
                {
                    switch(Depth)
                    {
                        case 2:
                            accepted = true;
                            Depth++;
                            Token = Token26.Dog;
                        break;
                    }
                }
                break;
                case h:
                {
                    switch(Depth)
                    {
                        // (h)ound
                        case 0:
                            accepted = true;
                            Depth++;
                        break;
                        // c(h)icken
                        case 1:
                            accepted = true;
                            Depth++;
                        break;
                    }
                }
                break;
                case i:
                {
                    switch(Depth)
                    {
                        // ch(i)cken
                        case 2:
                            accepted = true;
                            Depth++;
                        break;
                    }
                }
                break;
                case j:
                {
                    switch(Depth)
                    {
                        default:
                            accepted = false;
                            Depth = 0;
                        break;
                    }
                }
                break;
                case k:
                {
                    switch(Depth)
                    {
                        // chic(k)en
                        case 4:
                            accepted = true;
                            Depth++;
                        break;
                    }
                }
                break;
                case l:
                {
                    switch(Depth)
                    {
                        default:
                            accepted = false;
                            Depth = 0;
                        break;
                    }
                }
                break;
                case m:
                {
                    switch(Depth)
                    {
                        default:
                            accepted = false;
                            Depth = 0;
                        break;
                    }
                }
                break;
                case n:
                {
                    switch(Depth)
                    {
                        // hou(n)d
                        case 3:
                            accepted = true;
                            Depth++;
                        break;
                        // chicke(n)
                        case 6:
                            accepted = true;
                            Depth++;
                            Token = Token26.Chicken;
                        break;
                    }
                }
                break;
                case o:
                {
                    switch(Depth)
                    {
                        // d(o)g, f(o)x, ho(u)nd
                        case 1:
                            accepted = true;
                            Depth++;
                        break;
                    }
                }
                break;
                case p:
                {
                    switch(Depth)
                    {
                        default:
                            accepted = false;
                            Depth = 0;
                        break;
                    }
                }
                break;
                case q:
                {
                    switch(Depth)
                    {
                        default:
                            accepted = false;
                            Depth = 0;
                        break;
                    }
                }
                break;
                case r:
                {
                    switch(Depth)
                    {
                        default:
                            accepted = false;
                            Depth = 0;
                        break;
                    }
                }
                break;
                case s:
                {
                    switch(Depth)
                    {
                        default:
                            accepted = false;
                            Depth = 0;
                        break;
                    }
                }
                break;
                case t:
                {
                    switch(Depth)
                    {
                        // ca(t)
                        case 2:
                            accepted = true;
                            Depth++;
                            Token = Token26.Cat;
                        break;
                    }
                }
                break;
                case u:
                {
                    switch(Depth)
                    {
                        // ho(u)nd
                        case 2:
                            accepted = true;
                            Depth++;
                        break;
                    }
                }
                break;
                case v:
                {
                    switch(Depth)
                    {
                        default:
                            accepted = false;
                            Depth = 0;
                        break;
                    }
                }
                break;
                case w:
                {
                    switch(Depth)
                    {
                        default:
                            accepted = false;
                            Depth = 0;
                        break;
                    }
                }
                break;
                case x:
                {
                    switch(Depth)
                    {
                        // fo(x)
                        case 2:
                            accepted = true;
                            Depth++;
                            Token = Token26.Fox;
                        break;
                    }
                }
                break;
                case y:
                {
                    switch(Depth)
                    {
                        default:
                            accepted = false;
                            Depth = 0;
                        break;
                    }
                }
                break;
                case z:
                {
                    switch(Depth)
                    {
                        default:
                            accepted = false;
                            Depth = 0;
                        break;
                    }
                }
                break;
            }
            return accepted;
        }
    }
}
