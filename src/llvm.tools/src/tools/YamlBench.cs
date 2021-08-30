//-----------------------------------------------------------------------------
// Copyright   : (c) LLVM Project
// License     : Apache-2.0 WITH LLVM-exceptions
// Source      : llvm/lib/Support/YAMLParser.cpp
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;
    using System.Runtime.CompilerServices;

    using static YamlTokenFacets;
    using static Chars;

    using static core;
    using static Root;

    public class YamlBench : ToolService<YamlBench>
    {
        Symbols<YamlTokenKind> Kinds;

        public YamlBench()
        {
            Kinds = Symbols.index<YamlTokenKind>();
        }

        public override ToolId Id
            => Toolspace.yaml_bench;

        public Outcome ParseToken(string src, out YamlToken dst)
        {
            dst = YamlToken.Empty;
            var i = text.index(src,Chars.Colon);
            if(i >= 0)
            {
                var name = text.left(src,i);

            }


            return false;
        }

/*
        Alias:"Alias", Anchor:"Anchor",

        BlockEnd:"Block-End", BlockEntry:"Block-Entry", BlockMappingStart:"Block-Mapping-Start", BlockScalar:"Block Scalar", BlockSequenceStart:"Block-Sequence-Start",

        DocumentStart:"Document-Start", DocumentEnd:"Document-End",

        FlowEntry:"Flow-Entry", FlowMappingStart:"Flow-Mapping-Start", FlowMappingEnd:"Flow-Mapping-End", FlowSequenceStart:"Flow-Sequence-Start", FlowSequenceEnd:"Flow-Sequence-End",
        Key:"Key",

        Scalar:"Scalar", StreamStart:"Stream-Start", StreamEnd:"Stream-End",

        Tag:"Tag", TagDirective:"Tag-Directive",

        Value:"Value",VersionDirective:"Version-Directive",

*/
        [MethodImpl(Inline), Op]
        public static bool eq(ReadOnlySpan<char> a, ReadOnlySpan<char> b)
        {
            var count = a.Length;
            var result = count == b.Length;
            for(var i=0; i<count && result; i++)
                result = skip(a,i) == skip(b,i);
            return result;
        }

        Outcome ParseKind(ReadOnlySpan<char> src, out YamlTokenKind dst)
        {
            var result = Outcome.Failure;
            dst = 0;
            var count = src.Length;
            if(count < MinTokenLength)
                return (false, text.format(src));

            ref readonly var c0 = ref skip(src,0);
            ref readonly var c1 = ref skip(src,1);
            for(var level=2; level<count; level++)
            {
                ref readonly var current = ref skip(src,level);
                switch(c0)
                {
                    case A:
                        switch(c1)
                        {
                            case L:
                                switch(current)
                                {
                                    default:
                                    break;
                                }
                            break;
                            case N:
                                switch(current)
                                {
                                    default:
                                    break;
                                }
                            break;
                        }
                    break;

                    case B:
                        switch(c1)
                        {
                            case L:
                                switch(current)
                                {
                                    default:
                                    break;
                                }
                            break;
                        }
                    break;

                    case D:
                        switch(c1)
                        {
                            case o:
                                switch(current)
                                {
                                    default:
                                    break;
                                }
                            break;
                        }
                    break;

                    case F:
                        switch(c1)
                        {
                            case l:
                                switch(current)
                                {
                                    default:
                                    break;
                                }
                            break;
                        }
                    break;

                    case K:
                        switch(c1)
                        {
                            case e:
                                switch(current)
                                {
                                    default:
                                    break;
                                }
                            break;
                        }
                    break;

                    case S:
                        switch(c1)
                        {
                            case c:
                                switch(current)
                                {
                                    default:
                                    break;
                                }
                            break;
                            case t:
                                switch(current)
                                {
                                    default:
                                    break;
                                }
                            break;
                        }
                    break;

                    case T:
                        switch(c1)
                        {
                            case a:
                                switch(current)
                                {
                                    default:
                                    break;
                                }
                            break;
                        }
                    break;

                    case Chars.V:
                        switch(c1)
                        {
                            case a:
                                switch(current)
                                {
                                    default:
                                    break;
                                }
                            break;
                            case e:
                                switch(current)
                                {
                                    default:
                                    break;
                                }
                            break;
                        }
                    break;
                }
            }

            return result;
        }
    }
}