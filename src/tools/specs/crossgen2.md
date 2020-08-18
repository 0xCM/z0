Crossgen2Compilation [options] [<input-file-paths>...]

Arguments:
  <input-file-paths>    Input file(s) to compile

Options:
  -r, --reference <reference>                             Reference file(s) for compilation
  -o, --out, --outputfilepath <outputfilepath>            Output file path
  -O, --optimize                                          Enable optimizations
  --Os, --optimize-space                                  Enable optimizations, favor code space
  --Ot, --optimize-time                                   Enable optimizations, favor code speed
  --inputbubble                                           True when the entire input forms a version bubble (default = per-assembly bubble)
  --tuning                                                Generate IBC tuning image
  --partial                                               Generate partial image driven by profile
  --compilebubblegenerics                                 Compile instantiations from reference modules used in the current module
  --dmgllog, --dgml-log-file-name <dgml-log-file-name>    Save result of dependency analysis as DGML
  --fulllog, --generate-full-dmgl-log                     Save detailed log of dependency analysis
  --verbose                                               Enable verbose logging
  --systemmodule <systemmodule>                           System module name (default: System.Private.CoreLib)
  --waitfordebugger                                       Pause to give opportunity to attach debugger
  --codegenopt, --codegen-options <codegen-options>       Define a codegen option
  --resilient                                             Disable behavior where unexpected compilation failures cause overall compilation failure
  --targetarch <targetarch>                               Target architecture for cross compilation
  --targetos <targetos>                                   Target OS for cross compilation
  --jitpath <jitpath>                                     Path to JIT compiler library
  --singlemethodtypename <singlemethodtypename>           Single method compilation: name of the owning type
  --singlemethodname <singlemethodname>                   Single method compilation: generic arguments to the method
  --singlemethodgenericarg <singlemethodgenericarg>       Single method compilation: generic arguments to the method
  --version                                               Display version information