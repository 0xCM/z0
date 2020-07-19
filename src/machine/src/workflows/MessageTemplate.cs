//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct MessageTemplate<T>
    {
        public readonly string Pattern;
    }
    
    public readonly struct TemplateArg<T>
    {
        public readonly string Name;

        public readonly T Value;
    }

    public readonly struct TemplateArg
    {
        public readonly string Name;
        
        public readonly variant Value;
    }

    public readonly struct TemplateArgs
    {
        public readonly TemplateArg[] Data;

        public TemplateArgs(TemplateArg[] src)
        {
            Data = src;
        }
    }
}