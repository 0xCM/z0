bugpoint --help-hidden > bugpoint.help
dsymutil --help > dsymutil.help
filecheck --help-hidden > filecheck.help
llc --help-hidden > llc.help
lli --help-hidden > lli.help

lld-link -help > lld-link.help
llvm-addr2line --help > llvm-addr2line.help
llvm-ar --help-hidden > llvm-ar.help
llvm-as --help-hidden > llvm-as.help
llvm-bcanalyzer --help-hidden > llvm-bcanalyzer.help
llvm-cat --help-hidden > llvm-cat.help
llvm-cxxfilt --help-hidden > llvm-cxxfilt.help
llvm-cxxmap --help-hidden > llvm-cxxmap.help
llvm-diff --help-hidden > llvm-diff.help
llvm-dis --help-hidden > llvm-dis.help
llvm-exegesis --help-hidden > llvm-exegesis.help
llvm-extract --help-hidden > llvm-extract.help
llvm-jitlink --help-hidden > llvm-jitlink.help
llvm-link --help-hidden > llvm-link.help
llvm-lipo --help > llvm-lipo.help
llvm-mca --help-hidden > llvm-mca.help
llvm-ml --help-hidden > llvm-ml.help
llvm-modextract --help-hidden > llvm-modextract.help

llvm-readobj --help-hidden > llvm-readobj.help
llvm-stress --help-hidden > llvm-stress.help
llvm-symbolizer --help-hidden > llvm-symbolizer.help
llvm-objcopy --help > llvm-objcopy.help
llvm-install-name-tool --help > llvm-install-name-tool.help
llvm-nm --help-hidden > llvm-nm.help
llvm-objdump --help-hidden > llvm-objdump.help
llvm-ranlib --help > llvm-ranlib.help
llvm-size --help-hidden > llvm-size.help
llvm-strings --help-hidden > llvm-strings.help
llvm-strip --help > llvm-strip.help
opt --help-hidden > opt.help
llvm-tblgen --help > llvm-tblgen.help
llvm-xray --help > llvm-xray.help
obj2yaml --help-hidden > obj2yaml.help
llvm-dlltool --help-hidden > llvm-dlltool.help
llvm-pdbutil --help-hidden > llvm-pdbutil.help
llvm-pdbutil dump --help >> llvm-pdbutil.help
llvm-pdbutil diadump --help-hidden >> llvm-pdbutil.help

clang --help-hidden > clang.help

dir %path_llvm_build% > llvm-tools.log

clangd --help-hidden > clangd.help

clangd --help-list-hidden > clangd-list.help
clangd-indexer --help-hidden > clangd-indexer.help

mt -? > mt.help