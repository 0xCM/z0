//-----------------------------------------------------------------------------
// Copyright   : (c) LLVM Project
// License     : Apache-2.0 WITH LLVM-exceptions
// Source      : ws/sources/datasets/llvm.tblgen.headers/X86.gen-asm-writer.h
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    partial struct MC
    {
        const string AsmStrs =
        /* 0 */ "prefetcht0\t\0" +
        /* 12 */ "sha1msg1\t\0" +
        /* 22 */ "sha256msg1\t\0" +
        /* 34 */ "tileloaddt1\t\0" +
        /* 47 */ "prefetcht1\t\0" +
        /* 59 */ "pfrcpit1\t\0" +
        /* 69 */ "pfrsqit1\t\0" +
        /* 79 */ "prefetchwt1\t\0" +
        /* 92 */ "vmovdqa32\t\0" +
        /* 103 */ "crc32\t\0" +
        /* 110 */ "vmovdqu32\t\0" +
        /* 121 */ "sha1msg2\t\0" +
        /* 131 */ "sha256msg2\t\0" +
        /* 143 */ "sha256rnds2\t\0" +
        /* 156 */ "prefetcht2\t\0" +
        /* 168 */ "pfrcpit2\t\0" +
        /* 178 */ "vbroadcastf32x2\t\0" +
        /* 195 */ "vbroadcasti32x2\t\0" +
        /* 212 */ "vshuff64x2\t\0" +
        /* 224 */ "vextractf64x2\t\0" +
        /* 239 */ "vinsertf64x2\t\0" +
        /* 253 */ "vbroadcastf64x2\t\0" +
        /* 270 */ "vshufi64x2\t\0" +
        /* 282 */ "vextracti64x2\t\0" +
        /* 297 */ "vinserti64x2\t\0" +
        /* 311 */ "vbroadcasti64x2\t\0" +
        /* 328 */ "vmovdqa64\t\0" +
        /* 339 */ "xsavec64\t\0" +
        /* 349 */ "fxsave64\t\0" +
        /* 359 */ "fxrstor64\t\0" +
        /* 370 */ "xsaves64\t\0" +
        /* 380 */ "xrstors64\t\0" +
        /* 391 */ "xsaveopt64\t\0" +
        /* 403 */ "vmovdqu64\t\0" +
        /* 414 */ "sha1rnds4\t\0" +
        /* 425 */ "vshuff32x4\t\0" +
        /* 437 */ "vextractf32x4\t\0" +
        /* 452 */ "vinsertf32x4\t\0" +
        /* 466 */ "vbroadcastf32x4\t\0" +
        /* 483 */ "vshufi32x4\t\0" +
        /* 495 */ "vextracti32x4\t\0" +
        /* 510 */ "vinserti32x4\t\0" +
        /* 524 */ "vbroadcasti32x4\t\0" +
        /* 541 */ "vextractf64x4\t\0" +
        /* 556 */ "vinsertf64x4\t\0" +
        /* 570 */ "vbroadcastf64x4\t\0" +
        /* 587 */ "vextracti64x4\t\0" +
        /* 602 */ "vinserti64x4\t\0" +
        /* 616 */ "vbroadcasti64x4\t\0" +
        /* 633 */ "vcvtne2ps2bf16\t\0" +
        /* 649 */ "vcvtneps2bf16\t\0" +
        /* 664 */ "vmovdqu16\t\0" +
        /* 675 */ "encodekey256\t\0" +
        /* 689 */ "vperm2f128\t\0" +
        /* 701 */ "vextractf128\t\0" +
        /* 715 */ "vinsertf128\t\0" +
        /* 728 */ "vbroadcastf128\t\0" +
        /* 744 */ "vperm2i128\t\0" +
        /* 756 */ "vextracti128\t\0" +
        /* 770 */ "vinserti128\t\0" +
        /* 783 */ "vbroadcasti128\t\0" +
        /* 799 */ "encodekey128\t\0" +
        /* 813 */ "vmovdqu8\t\0" +
        /* 823 */ "vextractf32x8\t\0" +
        /* 838 */ "vinsertf32x8\t\0" +
        /* 852 */ "vbroadcastf32x8\t\0" +
        /* 869 */ "vextracti32x8\t\0" +
        /* 884 */ "vinserti32x8\t\0" +
        /* 898 */ "vbroadcasti32x8\t\0" +
        /* 915 */ "lea\t\0" +
        /* 920 */ "vmovntdqa\t\0" +
        /* 931 */ "vmovdqa\t\0" +
        /* 940 */ "prefetchnta\t\0" +
        /* 953 */ "vpermi2b\t\0" +
        /* 963 */ "vpmovm2b\t\0" +
        /* 973 */ "vpermt2b\t\0" +
        /* 983 */ "movdir64b\t\0" +
        /* 994 */ "cmpxchg16b\t\0" +
        /* 1006 */ "cmpxchg8b\t\0" +
        /* 1017 */ "vpshab\t\0" +
        /* 1025 */ "sbb\t\0" +
        /* 1030 */ "vpsubb\t\0" +
        /* 1038 */ "llwpcb\t\0" +
        /* 1046 */ "slwpcb\t\0" +
        /* 1054 */ "kaddb\t\0" +
        /* 1061 */ "vpaddb\t\0" +
        /* 1069 */ "kandb\t\0" +
        /* 1076 */ "vpexpandb\t\0" +
        /* 1087 */ "vpmovusdb\t\0" +
        /* 1098 */ "vpmovsdb\t\0" +
        /* 1108 */ "vpmovdb\t\0" +
        /* 1117 */ "vpshufb\t\0" +
        /* 1126 */ "vpavgb\t\0" +
        /* 1134 */ "vpmovmskb\t\0" +
        /* 1145 */ "vpshlb\t\0" +
        /* 1153 */ "kshiftlb\t\0" +
        /* 1163 */ "vgf2p8mulb\t\0" +
        /* 1175 */ "vpblendmb\t\0" +
        /* 1186 */ "vptestnmb\t\0" +
        /* 1197 */ "vpcomb\t\0" +
        /* 1205 */ "vpshufbitqmb\t\0" +
        /* 1219 */ "vpermb\t\0" +
        /* 1227 */ "vptestmb\t\0" +
        /* 1237 */ "kandnb\t\0" +
        /* 1245 */ "vpsignb\t\0" +
        /* 1254 */ "vpcmpb\t\0" +
        /* 1262 */ "vgf2p8affineqb\t\0" +
        /* 1278 */ "vpcmpeqb\t\0" +
        /* 1288 */ "vpmovusqb\t\0" +
        /* 1299 */ "vpmovsqb\t\0" +
        /* 1309 */ "vpmultishiftqb\t\0" +
        /* 1325 */ "vgf2p8affineinvqb\t\0" +
        /* 1344 */ "vpmovqb\t\0" +
        /* 1353 */ "korb\t\0" +
        /* 1359 */ "kxnorb\t\0" +
        /* 1367 */ "kxorb\t\0" +
        /* 1374 */ "vpinsrb\t\0" +
        /* 1383 */ "kshiftrb\t\0" +
        /* 1393 */ "vpextrb\t\0" +
        /* 1402 */ "vpabsb\t\0" +
        /* 1410 */ "vpsubsb\t\0" +
        /* 1419 */ "vpaddsb\t\0" +
        /* 1428 */ "vpminsb\t\0" +
        /* 1437 */ "stosb\t\0" +
        /* 1444 */ "cmpsb\t\0" +
        /* 1451 */ "vpcompressb\t\0" +
        /* 1464 */ "vpsubusb\t\0" +
        /* 1474 */ "vpaddusb\t\0" +
        /* 1484 */ "pavgusb\t\0" +
        /* 1493 */ "movsb\t\0" +
        /* 1500 */ "vpmaxsb\t\0" +
        /* 1509 */ "vpcmpgtb\t\0" +
        /* 1519 */ "vpopcntb\t\0" +
        /* 1529 */ "knotb\t\0" +
        /* 1536 */ "vprotb\t\0" +
        /* 1544 */ "vpbroadcastb\t\0" +
        /* 1558 */ "ktestb\t\0" +
        /* 1566 */ "kortestb\t\0" +
        /* 1576 */ "vpcomub\t\0" +
        /* 1585 */ "vpminub\t\0" +
        /* 1594 */ "vpcmpub\t\0" +
        /* 1603 */ "pfsub\t\0" +
        /* 1610 */ "fisub\t\0" +
        /* 1617 */ "vpmaxub\t\0" +
        /* 1626 */ "vpblendvb\t\0" +
        /* 1637 */ "kmovb\t\0" +
        /* 1644 */ "clwb\t\0" +
        /* 1650 */ "vpacksswb\t\0" +
        /* 1661 */ "vpackuswb\t\0" +
        /* 1672 */ "vpmovuswb\t\0" +
        /* 1683 */ "vpmovswb\t\0" +
        /* 1693 */ "vpmovwb\t\0" +
        /* 1702 */ "pfacc\t\0" +
        /* 1709 */ "pfnacc\t\0" +
        /* 1717 */ "pfpnacc\t\0" +
        /* 1726 */ "adc\t\0" +
        /* 1731 */ "vaesdec\t\0" +
        /* 1740 */ "xsavec\t\0" +
        /* 1748 */ "blcic\t\0" +
        /* 1755 */ "blsic\t\0" +
        /* 1762 */ "t1mskc\t\0" +
        /* 1770 */ "vaesimc\t\0" +
        /* 1779 */ "vaesenc\t\0" +
        /* 1788 */ "inc\t\0" +
        /* 1793 */ "btc\t\0" +
        /* 1798 */ "vpermi2d\t\0" +
        /* 1808 */ "vpmovm2d\t\0" +
        /* 1818 */ "vpermt2d\t\0" +
        /* 1828 */ "vpbroadcastmw2d\t\0" +
        /* 1845 */ "aad\t\0" +
        /* 1850 */ "vmread\t\0" +
        /* 1858 */ "vpshad\t\0" +
        /* 1866 */ "vpsrad\t\0" +
        /* 1874 */ "vphaddbd\t\0" +
        /* 1884 */ "vphaddubd\t\0" +
        /* 1895 */ "vphsubd\t\0" +
        /* 1904 */ "vpsubd\t\0" +
        /* 1912 */ "vpmovsxbd\t\0" +
        /* 1923 */ "vpmovzxbd\t\0" +
        /* 1934 */ "pfadd\t\0" +
        /* 1941 */ "fiadd\t\0" +
        /* 1948 */ "tileloadd\t\0" +
        /* 1959 */ "xadd\t\0" +
        /* 1965 */ "vphaddd\t\0" +
        /* 1974 */ "kaddd\t\0" +
        /* 1981 */ "vpaddd\t\0" +
        /* 1989 */ "vpshldd\t\0" +
        /* 1998 */ "kandd\t\0" +
        /* 2005 */ "vpandd\t\0" +
        /* 2013 */ "vpexpandd\t\0" +
        /* 2024 */ "vpblendd\t\0" +
        /* 2034 */ "vpgatherdd\t\0" +
        /* 2046 */ "vpscatterdd\t\0" +
        /* 2059 */ "vpshrdd\t\0" +
        /* 2068 */ "vpmacsdd\t\0" +
        /* 2078 */ "vpmacssdd\t\0" +
        /* 2089 */ "rdseed\t\0" +
        /* 2097 */ "tilestored\t\0" +
        /* 2109 */ "pi2fd\t\0" +
        /* 2116 */ "vpshufd\t\0" +
        /* 2125 */ "vpternlogd\t\0" +
        /* 2137 */ "pf2id\t\0" +
        /* 2144 */ "invpcid\t\0" +
        /* 2153 */ "rdpid\t\0" +
        /* 2160 */ "invvpid\t\0" +
        /* 2169 */ "fbld\t\0" +
        /* 2175 */ "fld\t\0" +
        /* 2180 */ "vpshld\t\0" +
        /* 2188 */ "fild\t\0" +
        /* 2194 */ "vpslld\t\0" +
        /* 2202 */ "vpmulld\t\0" +
        /* 2211 */ "vprold\t\0" +
        /* 2219 */ "vpsrld\t\0" +
        /* 2227 */ "vmptrld\t\0" +
        /* 2236 */ "kshiftld\t\0" +
        /* 2246 */ "enqcmd\t\0" +
        /* 2254 */ "vpblendmd\t\0" +
        /* 2265 */ "vptestnmd\t\0" +
        /* 2276 */ "vpcomd\t\0" +
        /* 2284 */ "vpermd\t\0" +
        /* 2292 */ "vptestmd\t\0" +
        /* 2302 */ "vpand\t\0" +
        /* 2309 */ "rdrand\t\0" +
        /* 2317 */ "kandnd\t\0" +
        /* 2325 */ "vpandnd\t\0" +
        /* 2334 */ "valignd\t\0" +
        /* 2343 */ "vpsignd\t\0" +
        /* 2352 */ "bound\t\0" +
        /* 2359 */ "vfmaddsub231pd\t\0" +
        /* 2375 */ "vfmsub231pd\t\0" +
        /* 2388 */ "vfnmsub231pd\t\0" +
        /* 2402 */ "vfmsubadd231pd\t\0" +
        /* 2418 */ "vfmadd231pd\t\0" +
        /* 2431 */ "vfnmadd231pd\t\0" +
        /* 2445 */ "vfmaddsub132pd\t\0" +
        /* 2461 */ "vfmsub132pd\t\0" +
        /* 2474 */ "vfnmsub132pd\t\0" +
        /* 2488 */ "vfmsubadd132pd\t\0" +
        /* 2504 */ "vfmadd132pd\t\0" +
        /* 2517 */ "vfnmadd132pd\t\0" +
        /* 2531 */ "vpermi2pd\t\0" +
        /* 2542 */ "cvtpi2pd\t\0" +
        /* 2552 */ "vpermil2pd\t\0" +
        /* 2564 */ "vexp2pd\t\0" +
        /* 2573 */ "vcvtdq2pd\t\0" +
        /* 2584 */ "vcvtudq2pd\t\0" +
        /* 2596 */ "vcvtqq2pd\t\0" +
        /* 2607 */ "vcvtuqq2pd\t\0" +
        /* 2619 */ "vcvtps2pd\t\0" +
        /* 2630 */ "vpermt2pd\t\0" +
        /* 2641 */ "vfmaddsub213pd\t\0" +
        /* 2657 */ "vfmsub213pd\t\0" +
        /* 2670 */ "vfnmsub213pd\t\0" +
        /* 2684 */ "vfmsubadd213pd\t\0" +
        /* 2700 */ "vfmadd213pd\t\0" +
        /* 2713 */ "vfnmadd213pd\t\0" +
        /* 2727 */ "vrcp14pd\t\0" +
        /* 2737 */ "vrsqrt14pd\t\0" +
        /* 2749 */ "vrcp28pd\t\0" +
        /* 2759 */ "vrsqrt28pd\t\0" +
        /* 2771 */ "vmovapd\t\0" +
        /* 2780 */ "pswapd\t\0" +
        /* 2788 */ "vfmaddsubpd\t\0" +
        /* 2801 */ "vaddsubpd\t\0" +
        /* 2812 */ "vhsubpd\t\0" +
        /* 2821 */ "vfmsubpd\t\0" +
        /* 2831 */ "vfnmsubpd\t\0" +
        /* 2842 */ "vsubpd\t\0" +
        /* 2850 */ "vfmsubaddpd\t\0" +
        /* 2863 */ "vhaddpd\t\0" +
        /* 2872 */ "vfmaddpd\t\0" +
        /* 2882 */ "vfnmaddpd\t\0" +
        /* 2893 */ "vaddpd\t\0" +
        /* 2901 */ "vexpandpd\t\0" +
        /* 2912 */ "vandpd\t\0" +
        /* 2920 */ "vblendpd\t\0" +
        /* 2930 */ "vroundpd\t\0" +
        /* 2940 */ "vgatherdpd\t\0" +
        /* 2952 */ "vscatterdpd\t\0" +
        /* 2965 */ "vreducepd\t\0" +
        /* 2976 */ "vrangepd\t\0" +
        /* 2986 */ "vrndscalepd\t\0" +
        /* 2999 */ "vscalefpd\t\0" +
        /* 3010 */ "vshufpd\t\0" +
        /* 3019 */ "vunpckhpd\t\0" +
        /* 3030 */ "vmovhpd\t\0" +
        /* 3039 */ "vmovmskpd\t\0" +
        /* 3050 */ "vpermilpd\t\0" +
        /* 3061 */ "vunpcklpd\t\0" +
        /* 3072 */ "vmulpd\t\0" +
        /* 3080 */ "vmovlpd\t\0" +
        /* 3089 */ "vpcmpd\t\0" +
        /* 3097 */ "vblendmpd\t\0" +
        /* 3108 */ "vfixupimmpd\t\0" +
        /* 3121 */ "vpermpd\t\0" +
        /* 3130 */ "vandnpd\t\0" +
        /* 3139 */ "vminpd\t\0" +
        /* 3147 */ "vdppd\t\0" +
        /* 3154 */ "vcmppd\t\0" +
        /* 3162 */ "vgetexppd\t\0" +
        /* 3173 */ "vgatherqpd\t\0" +
        /* 3185 */ "vscatterqpd\t\0" +
        /* 3198 */ "vorpd\t\0" +
        /* 3205 */ "vxorpd\t\0" +
        /* 3213 */ "vfpclasspd\t\0" +
        /* 3225 */ "incsspd\t\0" +
        /* 3234 */ "rdsspd\t\0" +
        /* 3242 */ "vcompresspd\t\0" +
        /* 3255 */ "vgetmantpd\t\0" +
        /* 3267 */ "vmovntpd\t\0" +
        /* 3277 */ "vsqrtpd\t\0" +
        /* 3286 */ "vtestpd\t\0" +
        /* 3295 */ "vmovupd\t\0" +
        /* 3304 */ "vblendvpd\t\0" +
        /* 3315 */ "vdivpd\t\0" +
        /* 3323 */ "vmaskmovpd\t\0" +
        /* 3335 */ "vmaxpd\t\0" +
        /* 3343 */ "vfrczpd\t\0" +
        /* 3352 */ "vpcmpeqd\t\0" +
        /* 3362 */ "vpgatherqd\t\0" +
        /* 3374 */ "vpscatterqd\t\0" +
        /* 3387 */ "vpmovusqd\t\0" +
        /* 3398 */ "vpmovsqd\t\0" +
        /* 3408 */ "vpmovqd\t\0" +
        /* 3417 */ "shrd\t\0" +
        /* 3423 */ "kord\t\0" +
        /* 3429 */ "kxnord\t\0" +
        /* 3437 */ "vpord\t\0" +
        /* 3444 */ "vprord\t\0" +
        /* 3452 */ "kxord\t\0" +
        /* 3459 */ "vpxord\t\0" +
        /* 3467 */ "vpinsrd\t\0" +
        /* 3476 */ "kshiftrd\t\0" +
        /* 3486 */ "vpextrd\t\0" +
        /* 3495 */ "vfmsub231sd\t\0" +
        /* 3508 */ "vfnmsub231sd\t\0" +
        /* 3522 */ "vfmadd231sd\t\0" +
        /* 3535 */ "vfnmadd231sd\t\0" +
        /* 3549 */ "vfmsub132sd\t\0" +
        /* 3562 */ "vfnmsub132sd\t\0" +
        /* 3576 */ "vfmadd132sd\t\0" +
        /* 3589 */ "vfnmadd132sd\t\0" +
        /* 3603 */ "vcvtsi2sd\t\0" +
        /* 3614 */ "vcvtusi2sd\t\0" +
        /* 3626 */ "vcvtss2sd\t\0" +
        /* 3637 */ "vfmsub213sd\t\0" +
        /* 3650 */ "vfnmsub213sd\t\0" +
        /* 3664 */ "vfmadd213sd\t\0" +
        /* 3677 */ "vfnmadd213sd\t\0" +
        /* 3691 */ "vrcp14sd\t\0" +
        /* 3701 */ "vrsqrt14sd\t\0" +
        /* 3713 */ "vrcp28sd\t\0" +
        /* 3723 */ "vrsqrt28sd\t\0" +
        /* 3735 */ "vpabsd\t\0" +
        /* 3743 */ "vfmsubsd\t\0" +
        /* 3753 */ "vfnmsubsd\t\0" +
        /* 3764 */ "vsubsd\t\0" +
        /* 3772 */ "vfmaddsd\t\0" +
        /* 3782 */ "vfnmaddsd\t\0" +
        /* 3793 */ "vaddsd\t\0" +
        /* 3801 */ "vroundsd\t\0" +
        /* 3811 */ "vreducesd\t\0" +
        /* 3822 */ "vrangesd\t\0" +
        /* 3832 */ "vrndscalesd\t\0" +
        /* 3845 */ "vscalefsd\t\0" +
        /* 3856 */ "vucomisd\t\0" +
        /* 3866 */ "vcomisd\t\0" +
        /* 3875 */ "vmulsd\t\0" +
        /* 3883 */ "vfixupimmsd\t\0" +
        /* 3896 */ "vpminsd\t\0" +
        /* 3905 */ "vminsd\t\0" +
        /* 3913 */ "stosd\t\0" +
        /* 3920 */ "vcmpsd\t\0" +
        /* 3928 */ "vgetexpsd\t\0" +
        /* 3939 */ "tdpbssd\t\0" +
        /* 3948 */ "vpcompressd\t\0" +
        /* 3961 */ "wrssd\t\0" +
        /* 3968 */ "vfpclasssd\t\0" +
        /* 3980 */ "wrussd\t\0" +
        /* 3988 */ "vp4dpwssd\t\0" +
        /* 3999 */ "vpdpwssd\t\0" +
        /* 4009 */ "vgetmantsd\t\0" +
        /* 4021 */ "movntsd\t\0" +
        /* 4030 */ "vsqrtsd\t\0" +
        /* 4039 */ "vbroadcastsd\t\0" +
        /* 4053 */ "vpdpbusd\t\0" +
        /* 4063 */ "tdpbusd\t\0" +
        /* 4072 */ "vdivsd\t\0" +
        /* 4080 */ "vmovsd\t\0" +
        /* 4088 */ "vpmaxsd\t\0" +
        /* 4097 */ "vmaxsd\t\0" +
        /* 4105 */ "vfrczsd\t\0" +
        /* 4114 */ "vp2intersectd\t\0" +
        /* 4129 */ "vpconflictd\t\0" +
        /* 4142 */ "lgdtd\t\0" +
        /* 4149 */ "sgdtd\t\0" +
        /* 4156 */ "lidtd\t\0" +
        /* 4163 */ "sidtd\t\0" +
        /* 4170 */ "vpcmpgtd\t\0" +
        /* 4180 */ "vpopcntd\t\0" +
        /* 4190 */ "vplzcntd\t\0" +
        /* 4200 */ "knotd\t\0" +
        /* 4207 */ "vprotd\t\0" +
        /* 4215 */ "vpbroadcastd\t\0" +
        /* 4229 */ "ktestd\t\0" +
        /* 4237 */ "kortestd\t\0" +
        /* 4247 */ "vpcomud\t\0" +
        /* 4256 */ "vpminud\t\0" +
        /* 4265 */ "vpcmpud\t\0" +
        /* 4274 */ "tdpbsud\t\0" +
        /* 4283 */ "tdpbuud\t\0" +
        /* 4292 */ "vpmaxud\t\0" +
        /* 4301 */ "vpsravd\t\0" +
        /* 4310 */ "vpshldvd\t\0" +
        /* 4320 */ "vpshrdvd\t\0" +
        /* 4330 */ "vpsllvd\t\0" +
        /* 4339 */ "vprolvd\t\0" +
        /* 4348 */ "vpsrlvd\t\0" +
        /* 4357 */ "vpmaskmovd\t\0" +
        /* 4369 */ "vmovd\t\0" +
        /* 4376 */ "vprorvd\t\0" +
        /* 4385 */ "vphsubwd\t\0" +
        /* 4395 */ "vphaddwd\t\0" +
        /* 4405 */ "vpmaddwd\t\0" +
        /* 4415 */ "vpunpckhwd\t\0" +
        /* 4427 */ "kunpckwd\t\0" +
        /* 4437 */ "vpunpcklwd\t\0" +
        /* 4449 */ "vpmacswd\t\0" +
        /* 4459 */ "vpmadcswd\t\0" +
        /* 4470 */ "vpmacsswd\t\0" +
        /* 4481 */ "vpmadcsswd\t\0" +
        /* 4493 */ "vphadduwd\t\0" +
        /* 4504 */ "vpmovsxwd\t\0" +
        /* 4515 */ "vpmovzxwd\t\0" +
        /* 4526 */ "movsxd\t\0" +
        /* 4534 */ "movbe\t\0" +
        /* 4541 */ "ffree\t\0" +
        /* 4548 */ "pfcmpge\t\0" +
        /* 4557 */ "loopne\t\0" +
        /* 4565 */ "loope\t\0" +
        /* 4572 */ "rdfsbase\t\0" +
        /* 4582 */ "wrfsbase\t\0" +
        /* 4592 */ "rdgsbase\t\0" +
        /* 4602 */ "wrgsbase\t\0" +
        /* 4612 */ "tpause\t\0" +
        /* 4620 */ "vmwrite\t\0" +
        /* 4629 */ "ptwrite\t\0" +
        /* 4638 */ "cldemote\t\0" +
        /* 4648 */ "sha1nexte\t\0" +
        /* 4659 */ "fnsave\t\0" +
        /* 4667 */ "fxsave\t\0" +
        /* 4675 */ "bsf\t\0" +
        /* 4680 */ "retf\t\0" +
        /* 4686 */ "neg\t\0" +
        /* 4691 */ "ldtilecfg\t\0" +
        /* 4702 */ "sttilecfg\t\0" +
        /* 4713 */ "cmpxchg\t\0" +
        /* 4722 */ "invlpg\t\0" +
        /* 4730 */ "prefetch\t\0" +
        /* 4740 */ "fxch\t\0" +
        /* 4746 */ "vcvtps2ph\t\0" +
        /* 4757 */ "vpmacsdqh\t\0" +
        /* 4768 */ "vpmacssdqh\t\0" +
        /* 4780 */ "clflush\t\0" +
        /* 4789 */ "push\t\0" +
        /* 4795 */ "blci\t\0" +
        /* 4801 */ "bzhi\t\0" +
        /* 4807 */ "cvttpd2pi\t\0" +
        /* 4818 */ "cvtpd2pi\t\0" +
        /* 4828 */ "cvttps2pi\t\0" +
        /* 4839 */ "cvtps2pi\t\0" +
        /* 4849 */ "senduipi\t\0" +
        /* 4859 */ "movdiri\t\0" +
        /* 4868 */ "vpcmpestri\t\0" +
        /* 4880 */ "vpcmpistri\t\0" +
        /* 4892 */ "vcvttsd2si\t\0" +
        /* 4904 */ "vcvtsd2si\t\0" +
        /* 4915 */ "vcvttss2si\t\0" +
        /* 4927 */ "vcvtss2si\t\0" +
        /* 4938 */ "blsi\t\0" +
        /* 4944 */ "vcvttsd2usi\t\0" +
        /* 4957 */ "vcvtsd2usi\t\0" +
        /* 4969 */ "vcvttss2usi\t\0" +
        /* 4982 */ "vcvtss2usi\t\0" +
        /* 4994 */ "movnti\t\0" +
        /* 5002 */ "bndmk\t\0" +
        /* 5009 */ "blcmsk\t\0" +
        /* 5017 */ "blsmsk\t\0" +
        /* 5025 */ "tzmsk\t\0" +
        /* 5032 */ "lwpval\t\0" +
        /* 5040 */ "bndcl\t\0" +
        /* 5047 */ "rcl\t\0" +
        /* 5052 */ "shl\t\0" +
        /* 5057 */ "aesdec256kl\t\0" +
        /* 5070 */ "aesenc256kl\t\0" +
        /* 5083 */ "aesdecwide256kl\t\0" +
        /* 5100 */ "aesencwide256kl\t\0" +
        /* 5117 */ "aesdec128kl\t\0" +
        /* 5130 */ "aesenc128kl\t\0" +
        /* 5143 */ "aesdecwide128kl\t\0" +
        /* 5160 */ "aesencwide128kl\t\0" +
        /* 5177 */ "lcall\t\0" +
        /* 5184 */ "blcfill\t\0" +
        /* 5193 */ "blsfill\t\0" +
        /* 5202 */ "rol\t\0" +
        /* 5207 */ "arpl\t\0" +
        /* 5213 */ "vpmacsdql\t\0" +
        /* 5224 */ "vpmacssdql\t\0" +
        /* 5236 */ "lsl\t\0" +
        /* 5241 */ "pfmul\t\0" +
        /* 5248 */ "fimul\t\0" +
        /* 5255 */ "vpmovb2m\t\0" +
        /* 5265 */ "vpmovd2m\t\0" +
        /* 5275 */ "vpmovq2m\t\0" +
        /* 5285 */ "vpmovw2m\t\0" +
        /* 5295 */ "aam\t\0" +
        /* 5300 */ "fcom\t\0" +
        /* 5306 */ "ficom\t\0" +
        /* 5313 */ "fucom\t\0" +
        /* 5320 */ "vpperm\t\0" +
        /* 5328 */ "vpcmpestrm\t\0" +
        /* 5340 */ "vpcmpistrm\t\0" +
        /* 5352 */ "bndcn\t\0" +
        /* 5359 */ "vpandn\t\0" +
        /* 5367 */ "xbegin\t\0" +
        /* 5375 */ "pfmin\t\0" +
        /* 5382 */ "vmxon\t\0" +
        /* 5389 */ "tilezero\t\0" +
        /* 5399 */ "bswap\t\0" +
        /* 5406 */ "fsubp\t\0" +
        /* 5413 */ "pfrcp\t\0" +
        /* 5420 */ "faddp\t\0" +
        /* 5427 */ "pdep\t\0" +
        /* 5433 */ "ffreep\t\0" +
        /* 5441 */ "fmulp\t\0" +
        /* 5448 */ "cmp\t\0" +
        /* 5453 */ "rex64 jmp\t\0" +
        /* 5464 */ "ljmp\t\0" +
        /* 5470 */ "fcomp\t\0" +
        /* 5477 */ "ficomp\t\0" +
        /* 5485 */ "fucomp\t\0" +
        /* 5493 */ "nop\t\0" +
        /* 5498 */ "loop\t\0" +
        /* 5504 */ "pop\t\0" +
        /* 5509 */ "fsubrp\t\0" +
        /* 5517 */ "fdivrp\t\0" +
        /* 5525 */ "rstorssp\t\0" +
        /* 5535 */ "fbstp\t\0" +
        /* 5542 */ "fstp\t\0" +
        /* 5548 */ "fistp\t\0" +
        /* 5555 */ "fisttp\t\0" +
        /* 5563 */ "vmovddup\t\0" +
        /* 5573 */ "vmovshdup\t\0" +
        /* 5584 */ "vmovsldup\t\0" +
        /* 5595 */ "#EH_SjLj_Setup\t\0" +
        /* 5611 */ "fdivp\t\0" +
        /* 5618 */ "vpbroadcastmb2q\t\0" +
        /* 5635 */ "vpermi2q\t\0" +
        /* 5645 */ "vpmovm2q\t\0" +
        /* 5655 */ "movdq2q\t\0" +
        /* 5664 */ "vpermt2q\t\0" +
        /* 5674 */ "vpshaq\t\0" +
        /* 5682 */ "vpsraq\t\0" +
        /* 5690 */ "vphaddbq\t\0" +
        /* 5700 */ "vphaddubq\t\0" +
        /* 5711 */ "vpsubq\t\0" +
        /* 5719 */ "vpmovsxbq\t\0" +
        /* 5730 */ "vpmovzxbq\t\0" +
        /* 5741 */ "vcvttpd2dq\t\0" +
        /* 5753 */ "vcvtpd2dq\t\0" +
        /* 5764 */ "movq2dq\t\0" +
        /* 5773 */ "vcvttps2dq\t\0" +
        /* 5785 */ "vcvtps2dq\t\0" +
        /* 5796 */ "vphsubdq\t\0" +
        /* 5806 */ "kaddq\t\0" +
        /* 5813 */ "vpaddq\t\0" +
        /* 5821 */ "vphadddq\t\0" +
        /* 5831 */ "vpunpckhdq\t\0" +
        /* 5843 */ "kunpckdq\t\0" +
        /* 5853 */ "vpshldq\t\0" +
        /* 5862 */ "vpunpckldq\t\0" +
        /* 5874 */ "vpslldq\t\0" +
        /* 5883 */ "vpsrldq\t\0" +
        /* 5892 */ "vpmuldq\t\0" +
        /* 5901 */ "kandq\t\0" +
        /* 5908 */ "vpandq\t\0" +
        /* 5916 */ "vpexpandq\t\0" +
        /* 5927 */ "vpunpckhqdq\t\0" +
        /* 5940 */ "vpunpcklqdq\t\0" +
        /* 5953 */ "vpclmulqdq\t\0" +
        /* 5965 */ "vpgatherdq\t\0" +
        /* 5977 */ "vpscatterdq\t\0" +
        /* 5990 */ "vpshrdq\t\0" +
        /* 5999 */ "vmovntdq\t\0" +
        /* 6009 */ "vcvttpd2udq\t\0" +
        /* 6022 */ "vcvtpd2udq\t\0" +
        /* 6034 */ "vcvttps2udq\t\0" +
        /* 6047 */ "vcvtps2udq\t\0" +
        /* 6059 */ "vphaddudq\t\0" +
        /* 6070 */ "vpmuludq\t\0" +
        /* 6080 */ "vpmovsxdq\t\0" +
        /* 6091 */ "vpmovzxdq\t\0" +
        /* 6102 */ "pfcmpeq\t\0" +
        /* 6111 */ "retfq\t\0" +
        /* 6118 */ "vpternlogq\t\0" +
        /* 6130 */ "vpshlq\t\0" +
        /* 6138 */ "vpsllq\t\0" +
        /* 6146 */ "vpmullq\t\0" +
        /* 6155 */ "vprolq\t\0" +
        /* 6163 */ "vpsrlq\t\0" +
        /* 6171 */ "kshiftlq\t\0" +
        /* 6181 */ "vpblendmq\t\0" +
        /* 6192 */ "vptestnmq\t\0" +
        /* 6203 */ "vpcomq\t\0" +
        /* 6211 */ "vpermq\t\0" +
        /* 6219 */ "vptestmq\t\0" +
        /* 6229 */ "kandnq\t\0" +
        /* 6237 */ "vpandnq\t\0" +
        /* 6246 */ "valignq\t\0" +
        /* 6255 */ "vpcmpq\t\0" +
        /* 6263 */ "incsspq\t\0" +
        /* 6272 */ "rdsspq\t\0" +
        /* 6280 */ "vcvttpd2qq\t\0" +
        /* 6292 */ "vcvtpd2qq\t\0" +
        /* 6303 */ "vcvttps2qq\t\0" +
        /* 6315 */ "vcvtps2qq\t\0" +
        /* 6326 */ "vpcmpeqq\t\0" +
        /* 6336 */ "vpgatherqq\t\0" +
        /* 6348 */ "vpscatterqq\t\0" +
        /* 6361 */ "vcvttpd2uqq\t\0" +
        /* 6374 */ "vcvtpd2uqq\t\0" +
        /* 6386 */ "vcvttps2uqq\t\0" +
        /* 6399 */ "vcvtps2uqq\t\0" +
        /* 6411 */ "korq\t\0" +
        /* 6417 */ "kxnorq\t\0" +
        /* 6425 */ "vporq\t\0" +
        /* 6432 */ "vprorq\t\0" +
        /* 6440 */ "kxorq\t\0" +
        /* 6447 */ "vpxorq\t\0" +
        /* 6455 */ "vpinsrq\t\0" +
        /* 6464 */ "kshiftrq\t\0" +
        /* 6474 */ "vpextrq\t\0" +
        /* 6483 */ "vpabsq\t\0" +
        /* 6491 */ "vpminsq\t\0" +
        /* 6500 */ "stosq\t\0" +
        /* 6507 */ "cmpsq\t\0" +
        /* 6514 */ "vpcompressq\t\0" +
        /* 6527 */ "wrssq\t\0" +
        /* 6534 */ "wrussq\t\0" +
        /* 6542 */ "movsq\t\0" +
        /* 6549 */ "vpmaxsq\t\0" +
        /* 6558 */ "vp2intersectq\t\0" +
        /* 6573 */ "vpconflictq\t\0" +
        /* 6586 */ "vpcmpgtq\t\0" +
        /* 6596 */ "vpopcntq\t\0" +
        /* 6606 */ "vplzcntq\t\0" +
        /* 6616 */ "movntq\t\0" +
        /* 6624 */ "knotq\t\0" +
        /* 6631 */ "vprotq\t\0" +
        /* 6639 */ "insertq\t\0" +
        /* 6648 */ "vpbroadcastq\t\0" +
        /* 6662 */ "ktestq\t\0" +
        /* 6670 */ "kortestq\t\0" +
        /* 6680 */ "vpmadd52huq\t\0" +
        /* 6693 */ "vpmadd52luq\t\0" +
        /* 6706 */ "vpcomuq\t\0" +
        /* 6715 */ "vpminuq\t\0" +
        /* 6724 */ "vpcmpuq\t\0" +
        /* 6733 */ "vpmaxuq\t\0" +
        /* 6742 */ "vpsravq\t\0" +
        /* 6751 */ "vpshldvq\t\0" +
        /* 6761 */ "vpshrdvq\t\0" +
        /* 6771 */ "vpsllvq\t\0" +
        /* 6780 */ "vprolvq\t\0" +
        /* 6789 */ "vpsrlvq\t\0" +
        /* 6798 */ "vpmaskmovq\t\0" +
        /* 6810 */ "vmovq\t\0" +
        /* 6817 */ "vprorvq\t\0" +
        /* 6826 */ "vphaddwq\t\0" +
        /* 6836 */ "vphadduwq\t\0" +
        /* 6847 */ "vpmovsxwq\t\0" +
        /* 6858 */ "vpmovzxwq\t\0" +
        /* 6869 */ "vmclear\t\0" +
        /* 6878 */ "lar\t\0" +
        /* 6883 */ "sar\t\0" +
        /* 6888 */ "pfsubr\t\0" +
        /* 6896 */ "fisubr\t\0" +
        /* 6904 */ "rcr\t\0" +
        /* 6909 */ "enter\t\0" +
        /* 6916 */ "shr\t\0" +
        /* 6921 */ "vpalignr\t\0" +
        /* 6931 */ "vpor\t\0" +
        /* 6937 */ "ror\t\0" +
        /* 6942 */ "umonitor\t\0" +
        /* 6952 */ "frstor\t\0" +
        /* 6960 */ "fxrstor\t\0" +
        /* 6969 */ "vpxor\t\0" +
        /* 6976 */ "verr\t\0" +
        /* 6982 */ "bsr\t\0" +
        /* 6987 */ "vldmxcsr\t\0" +
        /* 6997 */ "vstmxcsr\t\0" +
        /* 7007 */ "blsr\t\0" +
        /* 7013 */ "btr\t\0" +
        /* 7018 */ "ltr\t\0" +
        /* 7023 */ "str\t\0" +
        /* 7028 */ "bextr\t\0" +
        /* 7035 */ "fdivr\t\0" +
        /* 7042 */ "fidivr\t\0" +
        /* 7050 */ "movabs\t\0" +
        /* 7058 */ "blcs\t\0" +
        /* 7064 */ "lds\t\0" +
        /* 7069 */ "enqcmds\t\0" +
        /* 7078 */ "vp4dpwssds\t\0" +
        /* 7090 */ "vpdpwssds\t\0" +
        /* 7101 */ "vpdpbusds\t\0" +
        /* 7112 */ "les\t\0" +
        /* 7117 */ "xsaves\t\0" +
        /* 7125 */ "lfs\t\0" +
        /* 7130 */ "lgs\t\0" +
        /* 7135 */ "lwpins\t\0" +
        /* 7143 */ "vfmaddsub231ps\t\0" +
        /* 7159 */ "vfmsub231ps\t\0" +
        /* 7172 */ "vfnmsub231ps\t\0" +
        /* 7186 */ "vfmsubadd231ps\t\0" +
        /* 7202 */ "vfmadd231ps\t\0" +
        /* 7215 */ "vfnmadd231ps\t\0" +
        /* 7229 */ "vfmaddsub132ps\t\0" +
        /* 7245 */ "vfmsub132ps\t\0" +
        /* 7258 */ "vfnmsub132ps\t\0" +
        /* 7272 */ "vfmsubadd132ps\t\0" +
        /* 7288 */ "vfmadd132ps\t\0" +
        /* 7301 */ "vfnmadd132ps\t\0" +
        /* 7315 */ "vcvtpd2ps\t\0" +
        /* 7326 */ "vcvtph2ps\t\0" +
        /* 7337 */ "vpermi2ps\t\0" +
        /* 7348 */ "cvtpi2ps\t\0" +
        /* 7358 */ "vpermil2ps\t\0" +
        /* 7370 */ "vexp2ps\t\0" +
        /* 7379 */ "vcvtdq2ps\t\0" +
        /* 7390 */ "vcvtudq2ps\t\0" +
        /* 7402 */ "vcvtqq2ps\t\0" +
        /* 7413 */ "vcvtuqq2ps\t\0" +
        /* 7425 */ "vpermt2ps\t\0" +
        /* 7436 */ "vfmaddsub213ps\t\0" +
        /* 7452 */ "vfmsub213ps\t\0" +
        /* 7465 */ "vfnmsub213ps\t\0" +
        /* 7479 */ "vfmsubadd213ps\t\0" +
        /* 7495 */ "vfmadd213ps\t\0" +
        /* 7508 */ "vfnmadd213ps\t\0" +
        /* 7522 */ "vrcp14ps\t\0" +
        /* 7532 */ "vrsqrt14ps\t\0" +
        /* 7544 */ "tdpbf16ps\t\0" +
        /* 7555 */ "vdpbf16ps\t\0" +
        /* 7566 */ "vrcp28ps\t\0" +
        /* 7576 */ "vrsqrt28ps\t\0" +
        /* 7588 */ "vmovaps\t\0" +
        /* 7597 */ "vfmaddsubps\t\0" +
        /* 7610 */ "vaddsubps\t\0" +
        /* 7621 */ "vhsubps\t\0" +
        /* 7630 */ "vfmsubps\t\0" +
        /* 7640 */ "vfnmsubps\t\0" +
        /* 7651 */ "vsubps\t\0" +
        /* 7659 */ "vfmsubaddps\t\0" +
        /* 7672 */ "vhaddps\t\0" +
        /* 7681 */ "v4fmaddps\t\0" +
        /* 7692 */ "vfmaddps\t\0" +
        /* 7702 */ "v4fnmaddps\t\0" +
        /* 7714 */ "vfnmaddps\t\0" +
        /* 7725 */ "vaddps\t\0" +
        /* 7733 */ "vexpandps\t\0" +
        /* 7744 */ "vandps\t\0" +
        /* 7752 */ "vblendps\t\0" +
        /* 7762 */ "vroundps\t\0" +
        /* 7772 */ "vgatherdps\t\0" +
        /* 7784 */ "vscatterdps\t\0" +
        /* 7797 */ "vreduceps\t\0" +
        /* 7808 */ "vrangeps\t\0" +
        /* 7818 */ "vrndscaleps\t\0" +
        /* 7831 */ "vscalefps\t\0" +
        /* 7842 */ "vshufps\t\0" +
        /* 7851 */ "vunpckhps\t\0" +
        /* 7862 */ "vmovlhps\t\0" +
        /* 7872 */ "vmovhps\t\0" +
        /* 7881 */ "vmovmskps\t\0" +
        /* 7892 */ "vmovhlps\t\0" +
        /* 7902 */ "vpermilps\t\0" +
        /* 7913 */ "vunpcklps\t\0" +
        /* 7924 */ "vmulps\t\0" +
        /* 7932 */ "vmovlps\t\0" +
        /* 7941 */ "vblendmps\t\0" +
        /* 7952 */ "vfixupimmps\t\0" +
        /* 7965 */ "vpermps\t\0" +
        /* 7974 */ "vandnps\t\0" +
        /* 7983 */ "vminps\t\0" +
        /* 7991 */ "vrcpps\t\0" +
        /* 7999 */ "vdpps\t\0" +
        /* 8006 */ "vcmpps\t\0" +
        /* 8014 */ "vgetexpps\t\0" +
        /* 8025 */ "vgatherqps\t\0" +
        /* 8037 */ "vscatterqps\t\0" +
        /* 8050 */ "vorps\t\0" +
        /* 8057 */ "vxorps\t\0" +
        /* 8065 */ "vfpclassps\t\0" +
        /* 8077 */ "vcompressps\t\0" +
        /* 8090 */ "vextractps\t\0" +
        /* 8102 */ "vgetmantps\t\0" +
        /* 8114 */ "vmovntps\t\0" +
        /* 8124 */ "vinsertps\t\0" +
        /* 8135 */ "vrsqrtps\t\0" +
        /* 8145 */ "vsqrtps\t\0" +
        /* 8154 */ "vtestps\t\0" +
        /* 8163 */ "vmovups\t\0" +
        /* 8172 */ "vblendvps\t\0" +
        /* 8183 */ "vdivps\t\0" +
        /* 8191 */ "vmaskmovps\t\0" +
        /* 8203 */ "vmaxps\t\0" +
        /* 8211 */ "vfrczps\t\0" +
        /* 8220 */ "xrstors\t\0" +
        /* 8229 */ "vfmsub231ss\t\0" +
        /* 8242 */ "vfnmsub231ss\t\0" +
        /* 8256 */ "vfmadd231ss\t\0" +
        /* 8269 */ "vfnmadd231ss\t\0" +
        /* 8283 */ "vfmsub132ss\t\0" +
        /* 8296 */ "vfnmsub132ss\t\0" +
        /* 8310 */ "vfmadd132ss\t\0" +
        /* 8323 */ "vfnmadd132ss\t\0" +
        /* 8337 */ "vcvtsd2ss\t\0" +
        /* 8348 */ "vcvtsi2ss\t\0" +
        /* 8359 */ "vcvtusi2ss\t\0" +
        /* 8371 */ "vfmsub213ss\t\0" +
        /* 8384 */ "vfnmsub213ss\t\0" +
        /* 8398 */ "vfmadd213ss\t\0" +
        /* 8411 */ "vfnmadd213ss\t\0" +
        /* 8425 */ "vrcp14ss\t\0" +
        /* 8435 */ "vrsqrt14ss\t\0" +
        /* 8447 */ "vrcp28ss\t\0" +
        /* 8457 */ "vrsqrt28ss\t\0" +
        /* 8469 */ "vfmsubss\t\0" +
        /* 8479 */ "vfnmsubss\t\0" +
        /* 8490 */ "vsubss\t\0" +
        /* 8498 */ "v4fmaddss\t\0" +
        /* 8509 */ "vfmaddss\t\0" +
        /* 8519 */ "v4fnmaddss\t\0" +
        /* 8531 */ "vfnmaddss\t\0" +
        /* 8542 */ "vaddss\t\0" +
        /* 8550 */ "vroundss\t\0" +
        /* 8560 */ "vreducess\t\0" +
        /* 8571 */ "vrangess\t\0" +
        /* 8581 */ "vrndscaless\t\0" +
        /* 8594 */ "vscalefss\t\0" +
        /* 8605 */ "vucomiss\t\0" +
        /* 8615 */ "vcomiss\t\0" +
        /* 8624 */ "vmulss\t\0" +
        /* 8632 */ "vfixupimmss\t\0" +
        /* 8645 */ "vminss\t\0" +
        /* 8653 */ "vrcpss\t\0" +
        /* 8661 */ "vcmpss\t\0" +
        /* 8669 */ "vgetexpss\t\0" +
        /* 8680 */ "vfpclassss\t\0" +
        /* 8692 */ "vgetmantss\t\0" +
        /* 8704 */ "movntss\t\0" +
        /* 8713 */ "vrsqrtss\t\0" +
        /* 8723 */ "vsqrtss\t\0" +
        /* 8732 */ "vbroadcastss\t\0" +
        /* 8746 */ "vdivss\t\0" +
        /* 8754 */ "vmovss\t\0" +
        /* 8762 */ "vmaxss\t\0" +
        /* 8770 */ "vfrczss\t\0" +
        /* 8779 */ "bts\t\0" +
        /* 8784 */ "bt\t\0" +
        /* 8788 */ "lgdt\t\0" +
        /* 8794 */ "sgdt\t\0" +
        /* 8800 */ "lidt\t\0" +
        /* 8806 */ "sidt\t\0" +
        /* 8812 */ "lldt\t\0" +
        /* 8818 */ "sldt\t\0" +
        /* 8824 */ "ret\t\0" +
        /* 8829 */ "hreset\t\0" +
        /* 8837 */ "pfcmpgt\t\0" +
        /* 8846 */ "umwait\t\0" +
        /* 8854 */ "popcnt\t\0" +
        /* 8862 */ "lzcnt\t\0" +
        /* 8869 */ "tzcnt\t\0" +
        /* 8876 */ "int\t\0" +
        /* 8881 */ "not\t\0" +
        /* 8886 */ "invept\t\0" +
        /* 8894 */ "xsaveopt\t\0" +
        /* 8904 */ "clflushopt\t\0" +
        /* 8916 */ "xabort\t\0" +
        /* 8924 */ "pfrsqrt\t\0" +
        /* 8933 */ "vaesdeclast\t\0" +
        /* 8946 */ "vaesenclast\t\0" +
        /* 8959 */ "vptest\t\0" +
        /* 8967 */ "fst\t\0" +
        /* 8972 */ "fist\t\0" +
        /* 8978 */ "vaeskeygenassist\t\0" +
        /* 8996 */ "vmptrst\t\0" +
        /* 9005 */ "out\t\0" +
        /* 9010 */ "pext\t\0" +
        /* 9016 */ "bndcu\t\0" +
        /* 9023 */ "vlddqu\t\0" +
        /* 9031 */ "vmaskmovdqu\t\0" +
        /* 9044 */ "vmovdqu\t\0" +
        /* 9053 */ "fdiv\t\0" +
        /* 9059 */ "fidiv\t\0" +
        /* 9066 */ "fldenv\t\0" +
        /* 9074 */ "fnstenv\t\0" +
        /* 9083 */ "vpcmov\t\0" +
        /* 9091 */ "bndmov\t\0" +
        /* 9099 */ "vpermi2w\t\0" +
        /* 9109 */ "vpmovm2w\t\0" +
        /* 9119 */ "vpermt2w\t\0" +
        /* 9129 */ "vpshaw\t\0" +
        /* 9137 */ "vpsraw\t\0" +
        /* 9145 */ "vphsubbw\t\0" +
        /* 9155 */ "vdbpsadbw\t\0" +
        /* 9166 */ "vmpsadbw\t\0" +
        /* 9176 */ "vpsadbw\t\0" +
        /* 9185 */ "vphaddbw\t\0" +
        /* 9195 */ "vpunpckhbw\t\0" +
        /* 9207 */ "kunpckbw\t\0" +
        /* 9217 */ "vpunpcklbw\t\0" +
        /* 9229 */ "vphaddubw\t\0" +
        /* 9240 */ "vphsubw\t\0" +
        /* 9249 */ "vpsubw\t\0" +
        /* 9257 */ "vpmovsxbw\t\0" +
        /* 9268 */ "vpmovzxbw\t\0" +
        /* 9279 */ "fldcw\t\0" +
        /* 9286 */ "fnstcw\t\0" +
        /* 9294 */ "vphaddw\t\0" +
        /* 9303 */ "kaddw\t\0" +
        /* 9310 */ "vpaddw\t\0" +
        /* 9318 */ "vpshldw\t\0" +
        /* 9327 */ "kandw\t\0" +
        /* 9334 */ "vpexpandw\t\0" +
        /* 9345 */ "vpblendw\t\0" +
        /* 9355 */ "vpshrdw\t\0" +
        /* 9364 */ "vpackssdw\t\0" +
        /* 9375 */ "vpackusdw\t\0" +
        /* 9386 */ "vpmovusdw\t\0" +
        /* 9397 */ "vpmovsdw\t\0" +
        /* 9407 */ "vpmovdw\t\0" +
        /* 9416 */ "pi2fw\t\0" +
        /* 9423 */ "pshufw\t\0" +
        /* 9431 */ "vpavgw\t\0" +
        /* 9439 */ "prefetchw\t\0" +
        /* 9450 */ "vpshufhw\t\0" +
        /* 9460 */ "vpmulhw\t\0" +
        /* 9469 */ "pf2iw\t\0" +
        /* 9476 */ "vpshuflw\t\0" +
        /* 9486 */ "vpshlw\t\0" +
        /* 9494 */ "vpsllw\t\0" +
        /* 9502 */ "vpmullw\t\0" +
        /* 9511 */ "vpsrlw\t\0" +
        /* 9519 */ "kshiftlw\t\0" +
        /* 9529 */ "vpblendmw\t\0" +
        /* 9540 */ "vptestnmw\t\0" +
        /* 9551 */ "vpcomw\t\0" +
        /* 9559 */ "vpermw\t\0" +
        /* 9567 */ "vptestmw\t\0" +
        /* 9577 */ "kandnw\t\0" +
        /* 9585 */ "vpsignw\t\0" +
        /* 9594 */ "vpcmpw\t\0" +
        /* 9602 */ "vpcmpeqw\t\0" +
        /* 9612 */ "vpmovusqw\t\0" +
        /* 9623 */ "vpmovsqw\t\0" +
        /* 9633 */ "vpmovqw\t\0" +
        /* 9642 */ "verw\t\0" +
        /* 9648 */ "pmulhrw\t\0" +
        /* 9657 */ "korw\t\0" +
        /* 9663 */ "kxnorw\t\0" +
        /* 9671 */ "kxorw\t\0" +
        /* 9678 */ "vpinsrw\t\0" +
        /* 9687 */ "kshiftrw\t\0" +
        /* 9697 */ "vpextrw\t\0" +
        /* 9706 */ "vpabsw\t\0" +
        /* 9714 */ "vpmaddubsw\t\0" +
        /* 9726 */ "vphsubsw\t\0" +
        /* 9736 */ "vpsubsw\t\0" +
        /* 9745 */ "vphaddsw\t\0" +
        /* 9755 */ "vpaddsw\t\0" +
        /* 9764 */ "lmsw\t\0" +
        /* 9770 */ "smsw\t\0" +
        /* 9776 */ "vpminsw\t\0" +
        /* 9785 */ "stosw\t\0" +
        /* 9792 */ "cmpsw\t\0" +
        /* 9799 */ "vpmulhrsw\t\0" +
        /* 9810 */ "vpcompressw\t\0" +
        /* 9823 */ "fnstsw\t\0" +
        /* 9831 */ "vpsubusw\t\0" +
        /* 9841 */ "vpaddusw\t\0" +
        /* 9851 */ "movsw\t\0" +
        /* 9858 */ "vpmaxsw\t\0" +
        /* 9867 */ "lgdtw\t\0" +
        /* 9874 */ "sgdtw\t\0" +
        /* 9881 */ "lidtw\t\0" +
        /* 9888 */ "sidtw\t\0" +
        /* 9895 */ "vpcmpgtw\t\0" +
        /* 9905 */ "vpopcntw\t\0" +
        /* 9915 */ "knotw\t\0" +
        /* 9922 */ "vprotw\t\0" +
        /* 9930 */ "vpbroadcastw\t\0" +
        /* 9944 */ "ktestw\t\0" +
        /* 9952 */ "kortestw\t\0" +
        /* 9962 */ "vpmulhuw\t\0" +
        /* 9972 */ "vpcomuw\t\0" +
        /* 9981 */ "vpminuw\t\0" +
        /* 9990 */ "vpcmpuw\t\0" +
        /* 9999 */ "vphminposuw\t\0" +
        /* 10012 */ "vpmaxuw\t\0" +
        /* 10021 */ "vpsravw\t\0" +
        /* 10030 */ "vpshldvw\t\0" +
        /* 10040 */ "vpshrdvw\t\0" +
        /* 10050 */ "vpsllvw\t\0" +
        /* 10059 */ "vpsrlvw\t\0" +
        /* 10068 */ "kmovw\t\0" +
        /* 10075 */ "vpmacsww\t\0" +
        /* 10085 */ "vpmacssww\t\0" +
        /* 10096 */ "pfmax\t\0" +
        /* 10103 */ "adcx\t\0" +
        /* 10109 */ "bndldx\t\0" +
        /* 10117 */ "shlx\t\0" +
        /* 10123 */ "mulx\t\0" +
        /* 10129 */ "adox\t\0" +
        /* 10135 */ "sarx\t\0" +
        /* 10141 */ "shrx\t\0" +
        /* 10147 */ "rorx\t\0" +
        /* 10153 */ "movsx\t\0" +
        /* 10160 */ "bndstx\t\0" +
        /* 10168 */ "movzx\t\0" +
        /* 10175 */ "loadiwkey\t\0" +
        /* 10186 */ "clrssbsy\t\0" +
        /* 10196 */ "jecxz\t\0" +
        /* 10203 */ "jcxz\t\0" +
        /* 10209 */ "jrcxz\t\0" +
        /* 10216 */ "xorl\t$FP, \0" +
        /* 10227 */ "sbb\tal, \0" +
        /* 10236 */ "scasb\tal, \0" +
        /* 10247 */ "lodsb\tal, \0" +
        /* 10258 */ "sub\tal, \0" +
        /* 10267 */ "adc\tal, \0" +
        /* 10276 */ "add\tal, \0" +
        /* 10285 */ "and\tal, \0" +
        /* 10294 */ "in\tal, \0" +
        /* 10302 */ "cmp\tal, \0" +
        /* 10311 */ "xor\tal, \0" +
        /* 10320 */ "movabs\tal, \0" +
        /* 10332 */ "test\tal, \0" +
        /* 10342 */ "mov\tal, \0" +
        /* 10351 */ "fcmovnb\tst, \0" +
        /* 10364 */ "fsub\tst, \0" +
        /* 10374 */ "fcmovb\tst, \0" +
        /* 10386 */ "fadd\tst, \0" +
        /* 10396 */ "fcmovnbe\tst, \0" +
        /* 10410 */ "fcmovbe\tst, \0" +
        /* 10423 */ "fcmovne\tst, \0" +
        /* 10436 */ "fcmove\tst, \0" +
        /* 10448 */ "fcomi\tst, \0" +
        /* 10459 */ "fucomi\tst, \0" +
        /* 10471 */ "fcompi\tst, \0" +
        /* 10483 */ "fucompi\tst, \0" +
        /* 10496 */ "fmul\tst, \0" +
        /* 10506 */ "fsubr\tst, \0" +
        /* 10517 */ "fdivr\tst, \0" +
        /* 10528 */ "fcmovnu\tst, \0" +
        /* 10541 */ "fcmovu\tst, \0" +
        /* 10553 */ "fdiv\tst, \0" +
        /* 10563 */ "sbb\tax, \0" +
        /* 10572 */ "sub\tax, \0" +
        /* 10581 */ "adc\tax, \0" +
        /* 10590 */ "add\tax, \0" +
        /* 10599 */ "and\tax, \0" +
        /* 10608 */ "xchg\tax, \0" +
        /* 10618 */ "in\tax, \0" +
        /* 10626 */ "cmp\tax, \0" +
        /* 10635 */ "xor\tax, \0" +
        /* 10644 */ "movabs\tax, \0" +
        /* 10656 */ "test\tax, \0" +
        /* 10666 */ "mov\tax, \0" +
        /* 10675 */ "scasw\tax, \0" +
        /* 10686 */ "lodsw\tax, \0" +
        /* 10697 */ "sbb\teax, \0" +
        /* 10707 */ "sub\teax, \0" +
        /* 10717 */ "adc\teax, \0" +
        /* 10727 */ "add\teax, \0" +
        /* 10737 */ "and\teax, \0" +
        /* 10747 */ "scasd\teax, \0" +
        /* 10759 */ "lodsd\teax, \0" +
        /* 10771 */ "xchg\teax, \0" +
        /* 10782 */ "in\teax, \0" +
        /* 10791 */ "cmp\teax, \0" +
        /* 10801 */ "xor\teax, \0" +
        /* 10811 */ "movabs\teax, \0" +
        /* 10824 */ "test\teax, \0" +
        /* 10835 */ "mov\teax, \0" +
        /* 10845 */ "sbb\trax, \0" +
        /* 10855 */ "sub\trax, \0" +
        /* 10865 */ "adc\trax, \0" +
        /* 10875 */ "add\trax, \0" +
        /* 10885 */ "and\trax, \0" +
        /* 10895 */ "xchg\trax, \0" +
        /* 10906 */ "cmp\trax, \0" +
        /* 10916 */ "scasq\trax, \0" +
        /* 10928 */ "lodsq\trax, \0" +
        /* 10940 */ "xor\trax, \0" +
        /* 10950 */ "movabs\trax, \0" +
        /* 10963 */ "test\trax, \0" +
        /* 10974 */ "mov\trax, \0" +
        /* 10984 */ "outsb\tdx, \0" +
        /* 10995 */ "outsd\tdx, \0" +
        /* 11006 */ "outsw\tdx, \0" +
        /* 11017 */ "ud1 \0" +
        /* 11022 */ "#VAARG_X32 \0" +
        /* 11034 */ "#VAARG_64 \0" +
        /* 11045 */ "ret\t#eh_return, addr: \0" +
        /* 11068 */ "#SEH_SaveXMM \0" +
        /* 11082 */ "xorq\t$FP \0" +
        /* 11092 */ "#VASTART_SAVE_XMM_REGS \0" +
        /* 11116 */ "#SEH_StackAlloc \0" +
        /* 11133 */ "#SEH_PushFrame \0" +
        /* 11149 */ "#SEH_SetFrame \0" +
        /* 11164 */ "#SEH_SaveReg \0" +
        /* 11178 */ "#SEH_PushReg \0" +
        /* 11192 */ "#SEH_StackAlign \0" +
        /* 11209 */ "#CMOV__RFP80 PSEUDO!\0" +
        /* 11230 */ "#CMOV__VK1 PSEUDO!\0" +
        /* 11249 */ "#CMOV__VR512 PSEUDO!\0" +
        /* 11270 */ "#CMOV__VK32 PSEUDO!\0" +
        /* 11290 */ "#CMOV__RFP32 PSEUDO!\0" +
        /* 11311 */ "#CMOV__FR32 PSEUDO!\0" +
        /* 11331 */ "#CMOV__GR32 PSEUDO!\0" +
        /* 11351 */ "#CMOV__VK2 PSEUDO!\0" +
        /* 11370 */ "#CMOV__VK64 PSEUDO!\0" +
        /* 11390 */ "#CMOV__RFP64 PSEUDO!\0" +
        /* 11411 */ "#CMOV__FR64 PSEUDO!\0" +
        /* 11431 */ "#CMOV__VR64 PSEUDO!\0" +
        /* 11451 */ "#CMOV__VK4 PSEUDO!\0" +
        /* 11470 */ "#CMOV__VK16 PSEUDO!\0" +
        /* 11490 */ "#CMOV__GR16 PSEUDO!\0" +
        /* 11510 */ "#CMOV__VR256 PSEUDO!\0" +
        /* 11531 */ "#CMOV__VR128 PSEUDO!\0" +
        /* 11552 */ "#CMOV__VK8 PSEUDO!\0" +
        /* 11571 */ "#CMOV__GR8 PSEUDO!\0" +
        /* 11590 */ "#CMOV__FR32X PSEUDO!\0" +
        /* 11611 */ "#CMOV__FR64X PSEUDO!\0" +
        /* 11632 */ "#CMOV__VR256X PSEUDO!\0" +
        /* 11654 */ "#CMOV__VR128X PSEUDO!\0" +
        /* 11676 */ "# XRay Function Patchable RET.\0" +
        /* 11707 */ "# XRay Typed Event Log.\0" +
        /* 11731 */ "# XRay Custom Event Log.\0" +
        /* 11756 */ "# XRay Function Enter.\0" +
        /* 11779 */ "# XRay Tail Call Exit.\0" +
        /* 11802 */ "# XRay Function Exit.\0" +
        /* 11824 */ "xsha1\0" +
        /* 11830 */ "fld1\0" +
        /* 11835 */ "fprem1\0" +
        /* 11842 */ "f2xm1\0" +
        /* 11848 */ "fyl2xp1\0" +
        /* 11856 */ "#EH_SJLJ_LONGJMP32\0" +
        /* 11875 */ "#EH_SJLJ_SETJMP32\0" +
        /* 11893 */ "# TLS_addrX32\0" +
        /* 11907 */ "# TLS_base_addrX32\0" +
        /* 11926 */ "# TLSCall_32\0" +
        /* 11939 */ "endbr32\0" +
        /* 11947 */ "# TLS_addr32\0" +
        /* 11960 */ "# TLS_base_addr32\0" +
        /* 11978 */ "ud2\0" +
        /* 11982 */ "fldlg2\0" +
        /* 11989 */ "fldln2\0" +
        /* 11996 */ "int3\0" +
        /* 12001 */ "#EH_SJLJ_LONGJMP64\0" +
        /* 12020 */ "#EH_SJLJ_SETJMP64\0" +
        /* 12038 */ "# TLSCall_64\0" +
        /* 12051 */ "endbr64\0" +
        /* 12059 */ "# TLS_addr64\0" +
        /* 12072 */ "# TLS_base_addr64\0" +
        /* 12090 */ "rex64\0" +
        /* 12096 */ "data16\0" +
        /* 12103 */ "addr16\0" +
        /* 12110 */ "xsha256\0" +
        /* 12118 */ "LIFETIME_END\0" +
        /* 12131 */ "PSEUDO_PROBE\0" +
        /* 12144 */ "BUNDLE\0" +
        /* 12151 */ "DBG_VALUE\0" +
        /* 12161 */ "# XABORT DEF\0" +
        /* 12174 */ "DBG_INSTR_REF\0" +
        /* 12188 */ "DBG_PHI\0" +
        /* 12196 */ "DBG_LABEL\0" +
        /* 12206 */ "# XBEGIN\0" +
        /* 12215 */ "#ADJCALLSTACKDOWN\0" +
        /* 12233 */ "#ADJCALLSTACKUP\0" +
        /* 12249 */ "#MEMBARRIER\0" +
        /* 12261 */ "# CATCHRET\0" +
        /* 12272 */ "# CLEANUPRET\0" +
        /* 12285 */ "LIFETIME_START\0" +
        /* 12300 */ "DBG_VALUE_LIST\0" +
        /* 12315 */ "rep movsb es:[edi], [esi]\0" +
        /* 12341 */ "rep movsd es:[edi], [esi]\0" +
        /* 12367 */ "rep movsq es:[edi], [esi]\0" +
        /* 12393 */ "rep movsw es:[edi], [esi]\0" +
        /* 12419 */ "rep movsb es:[rdi], [rsi]\0" +
        /* 12445 */ "rep movsdi es:[rdi], [rsi]\0" +
        /* 12472 */ "rep movsq es:[rdi], [rsi]\0" +
        /* 12498 */ "rep movsw es:[rdi], [rsi]\0" +
        /* 12524 */ "aaa\0" +
        /* 12528 */ "daa\0" +
        /* 12532 */ "invlpga\0" +
        /* 12540 */ "xcryptecb\0" +
        /* 12550 */ "xcryptcfb\0" +
        /* 12560 */ "xcryptofb\0" +
        /* 12570 */ "invlpgb\0" +
        /* 12578 */ "xlatb\0" +
        /* 12584 */ "clac\0" +
        /* 12589 */ "stac\0" +
        /* 12594 */ "xcryptcbc\0" +
        /* 12604 */ "getsec\0" +
        /* 12611 */ "salc\0" +
        /* 12616 */ "clc\0" +
        /* 12620 */ "cmc\0" +
        /* 12624 */ "rdpmc\0" +
        /* 12630 */ "vmfunc\0" +
        /* 12637 */ "tlbsync\0" +
        /* 12645 */ "rdtsc\0" +
        /* 12651 */ "stc\0" +
        /* 12655 */ "vmload\0" +
        /* 12662 */ "pushfd\0" +
        /* 12669 */ "popfd\0" +
        /* 12675 */ "cpuid\0" +
        /* 12681 */ "cld\0" +
        /* 12685 */ "xend\0" +
        /* 12690 */ "iretd\0" +
        /* 12696 */ "std\0" +
        /* 12700 */ "wbinvd\0" +
        /* 12707 */ "wbnoinvd\0" +
        /* 12716 */ "cwd\0" +
        /* 12720 */ "fldl2e\0" +
        /* 12727 */ "lfence\0" +
        /* 12734 */ "mfence\0" +
        /* 12741 */ "sfence\0" +
        /* 12748 */ "cwde\0" +
        /* 12753 */ "fscale\0" +
        /* 12760 */ "vmresume\0" +
        /* 12769 */ "repne\0" +
        /* 12775 */ "cdqe\0" +
        /* 12780 */ "xacquire\0" +
        /* 12789 */ "xstore\0" +
        /* 12796 */ "tilerelease\0" +
        /* 12808 */ "xrelease\0" +
        /* 12817 */ "pause\0" +
        /* 12823 */ "pvalidate\0" +
        /* 12833 */ "rmpupdate\0" +
        /* 12843 */ "#SEH_Epilogue\0" +
        /* 12857 */ "#SEH_EndPrologue\0" +
        /* 12874 */ "leave\0" +
        /* 12880 */ "vmsave\0" +
        /* 12887 */ "serialize\0" +
        /* 12897 */ "vmxoff\0" +
        /* 12904 */ "lahf\0" +
        /* 12909 */ "sahf\0" +
        /* 12914 */ "pushf\0" +
        /* 12920 */ "popf\0" +
        /* 12925 */ "retf\0" +
        /* 12930 */ "pconfig\0" +
        /* 12938 */ "# variable sized alloca with probing\0" +
        /* 12975 */ "# fixed size alloca with probing\0" +
        /* 13008 */ "vmlaunch\0" +
        /* 13017 */ "psmash\0" +
        /* 13024 */ "clgi\0" +
        /* 13029 */ "stgi\0" +
        /* 13034 */ "cli\0" +
        /* 13038 */ "fldpi\0" +
        /* 13044 */ "sti\0" +
        /* 13048 */ "clui\0" +
        /* 13053 */ "testui\0" +
        /* 13060 */ "j\0" +
        /* 13062 */ "lock\0" +
        /* 13067 */ "xresldtrk\0" +
        /* 13077 */ "xsusldtrk\0" +
        /* 13087 */ "rep stosb es:[edi], al\0" +
        /* 13110 */ "rep stosb es:[rdi], al\0" +
        /* 13133 */ "out\tdx, al\0" +
        /* 13144 */ "pushal\0" +
        /* 13151 */ "popal\0" +
        /* 13157 */ "# FEntry call\0" +
        /* 13171 */ "tdcall\0" +
        /* 13178 */ "seamcall\0" +
        /* 13187 */ "vmmcall\0" +
        /* 13195 */ "vmcall\0" +
        /* 13202 */ "syscall\0" +
        /* 13210 */ "vzeroall\0" +
        /* 13219 */ "montmul\0" +
        /* 13227 */ "fxam\0" +
        /* 13232 */ "fprem\0" +
        /* 13238 */ "rsm\0" +
        /* 13242 */ "fpatan\0" +
        /* 13249 */ "fptan\0" +
        /* 13255 */ "fsin\0" +
        /* 13260 */ "# dynamic stack allocation\0" +
        /* 13287 */ "vmrun\0" +
        /* 13293 */ "cqo\0" +
        /* 13297 */ "clzero\0" +
        /* 13304 */ "into\0" +
        /* 13309 */ "rdtscp\0" +
        /* 13316 */ "rep\0" +
        /* 13320 */ "fnop\0" +
        /* 13325 */ "fcompp\0" +
        /* 13332 */ "fucompp\0" +
        /* 13340 */ "saveprevssp\0" +
        /* 13352 */ "fdecstp\0" +
        /* 13360 */ "fincstp\0" +
        /* 13368 */ "cdq\0" +
        /* 13372 */ "pushfq\0" +
        /* 13379 */ "popfq\0" +
        /* 13385 */ "retfq\0" +
        /* 13391 */ "iretq\0" +
        /* 13397 */ "sysretq\0" +
        /* 13405 */ "sysexitq\0" +
        /* 13414 */ "vzeroupper\0" +
        /* 13425 */ "sysenter\0" +
        /* 13434 */ "monitor\0" +
        /* 13442 */ "rdmsr\0" +
        /* 13448 */ "wrmsr\0" +
        /* 13454 */ "xcryptctr\0" +
        /* 13464 */ "aas\0" +
        /* 13468 */ "das\0" +
        /* 13472 */ "fabs\0" +
        /* 13477 */ "push\tcs\0" +
        /* 13485 */ "push\tds\0" +
        /* 13493 */ "pop\tds\0" +
        /* 13500 */ "push\tes\0" +
        /* 13508 */ "pop\tes\0" +
        /* 13515 */ "push\tfs\0" +
        /* 13523 */ "pop\tfs\0" +
        /* 13530 */ "push\tgs\0" +
        /* 13538 */ "pop\tgs\0" +
        /* 13545 */ "swapgs\0" +
        /* 13552 */ "fchs\0" +
        /* 13557 */ "# variable sized alloca for segmented stacks\0" +
        /* 13602 */ "encls\0" +
        /* 13608 */ "femms\0" +
        /* 13614 */ "fcos\0" +
        /* 13619 */ "fsincos\0" +
        /* 13627 */ "seamops\0" +
        /* 13635 */ "push\tss\0" +
        /* 13643 */ "pop\tss\0" +
        /* 13650 */ "clts\0" +
        /* 13655 */ "fldl2t\0" +
        /* 13662 */ "fxtract\0" +
        /* 13670 */ "uiret\0" +
        /* 13676 */ "seamret\0" +
        /* 13684 */ "sysret\0" +
        /* 13691 */ "set\0" +
        /* 13695 */ "mwait\0" +
        /* 13701 */ "skinit\0" +
        /* 13708 */ "fninit\0" +
        /* 13715 */ "sysexit\0" +
        /* 13723 */ "hlt\0" +
        /* 13727 */ "frndint\0" +
        /* 13735 */ "fsqrt\0" +
        /* 13741 */ "xtest\0" +
        /* 13747 */ "ftst\0" +
        /* 13752 */ "rmpadjust\0" +
        /* 13762 */ "enclu\0" +
        /* 13768 */ "rdpkru\0" +
        /* 13775 */ "wrpkru\0" +
        /* 13782 */ "xgetbv\0" +
        /* 13789 */ "xsetbv\0" +
        /* 13796 */ "enclv\0" +
        /* 13802 */ "cmov\0" +
        /* 13807 */ "pushaw\0" +
        /* 13814 */ "popaw\0" +
        /* 13820 */ "cbw\0" +
        /* 13824 */ "fyl2x\0" +
        /* 13830 */ "fnstsw\tax\0" +
        /* 13840 */ "rep stosw es:[edi], ax\0" +
        /* 13863 */ "rep stosw es:[rdi], ax\0" +
        /* 13886 */ "out\tdx, ax\0" +
        /* 13897 */ "rep stosd es:[edi], eax\0" +
        /* 13921 */ "rep stosd es:[rdi], eax\0" +
        /* 13945 */ "out\tdx, eax\0" +
        /* 13957 */ "rep stosq es:[edi], rax\0" +
        /* 13981 */ "rep stosq es:[rdi], rax\0" +
        /* 14005 */ "in\tal, dx\0" +
        /* 14015 */ "in\tax, dx\0" +
        /* 14025 */ "in\teax, dx\0" +
        /* 14036 */ "fnclex\0" +
        /* 14043 */ "monitorx\0" +
        /* 14052 */ "mwaitx\0" +
        /* 14059 */ "setssbsy\0" +
        /* 14068 */ "fldz\0" +
        /* 14073 */ "vgatherpf0dpd\t{\0" +
        /* 14089 */ "vscatterpf0dpd\t{\0" +
        /* 14106 */ "vgatherpf1dpd\t{\0" +
        /* 14122 */ "vscatterpf1dpd\t{\0" +
        /* 14139 */ "vgatherpf0qpd\t{\0" +
        /* 14155 */ "vscatterpf0qpd\t{\0" +
        /* 14172 */ "vgatherpf1qpd\t{\0" +
        /* 14188 */ "vscatterpf1qpd\t{\0" +
        /* 14205 */ "vgatherpf0dps\t{\0" +
        /* 14221 */ "vscatterpf0dps\t{\0" +
        /* 14238 */ "vgatherpf1dps\t{\0" +
        /* 14254 */ "vscatterpf1dps\t{\0" +
        /* 14271 */ "vgatherpf0qps\t{\0" +
        /* 14287 */ "vscatterpf0qps\t{\0" +
        /* 14304 */ "vgatherpf1qps\t{\0" +
        /* 14320 */ "vscatterpf1qps\t{\0" +
        /* 14337 */ "invlpgb}\0";
    }
 }