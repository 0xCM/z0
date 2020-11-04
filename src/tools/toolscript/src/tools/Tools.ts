declare let z0: "./Tools"
export default z0;

export type ToolId = string

export type FilePath = {
    Name: string
}

export type UsageEmitCmd = {
    Tool: ToolId
    Option: string
}

export type UsageExample = {
    Tool: ToolId
    Content: string
}

export type UsageExamples<T> = [T, Array<string>]

export type ToolSource = {
    Path: FilePath
}

export type UsageDoc<T> = [T, string]

export type ToolTarget = {
    Path: FilePath,
}

export type ToolOption<T> = {
   Name: T,
   Meaning: string
}

export type None = {}

export type File = {Value: string}

export type Number = {Value: number}

export type Name = {Value: string}

export type ArgValue = None | File | Number | Name

export type ToolArg<F> = [F, ArgValue] | F

export type ToolFlag<T> = [T, string]

export type ToolVar<T> =  [T, string]

export type ExitCode<C> = [C, string]


export type ToolArgs<T,F> = [T, Array<ToolArg<F>>]

export type ExitCodes<T,C> = [T, Array<ExitCode<C>>]


export type ToolFlags<T,F> = [T, Array<ToolFlag<F>>]


export type ToolOptions<T> = {
    Tool: ToolId,
    Values: Array<ToolOption<T>>
}

export type ToolVars<T> = {
    Tool: ToolId,
    Values: Array<ToolVar<T>>
}

export type FlagSynonym<T> = [T, T]

export type FlagSynonyms<T,S> = [T, Array<FlagSynonym<S>>]

export interface ITextual
{
    Format() : string
}

export interface IToolCmd<T>
{
    Tool: ToolId
    Options: [T],
    Source: ToolSource,
    Target: ToolTarget,
}
