declare let z0: "./Tools"
export default z0;

export type FilePath = {
    Name : string
}

export type ToolSource = {
    Path : FilePath
}

export type ToolTarget = {
    Path : FilePath,
}

export type ToolId = string

export interface IToolCmd<T>  {
    Tool: ToolId
    Options: [T],
    Source: ToolSource,
    Target: ToolTarget,
}

