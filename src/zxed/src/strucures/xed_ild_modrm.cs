//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    using System;

    partial class Xed
    {
        ReadOnlySpan<byte> has_modrm_map_0x0 => new byte[256]{
        /*opcode 0x0*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x1*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x2*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x3*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x4*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x5*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x6*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x7*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x8*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x9*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xa*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xb*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xc*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xd*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xe*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xf*/ XED_ILD_HASMODRM_UNDEF,
        /*opcode 0x10*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x11*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x12*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x13*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x14*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x15*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x16*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x17*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x18*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x19*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x1a*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x1b*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x1c*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x1d*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x1e*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x1f*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x20*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x21*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x22*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x23*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x24*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x25*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x26*/ XED_ILD_HASMODRM_UNDEF,
        /*opcode 0x27*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x28*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x29*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x2a*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x2b*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x2c*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x2d*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x2e*/ XED_ILD_HASMODRM_UNDEF,
        /*opcode 0x2f*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x30*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x31*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x32*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x33*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x34*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x35*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x36*/ XED_ILD_HASMODRM_UNDEF,
        /*opcode 0x37*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x38*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x39*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x3a*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x3b*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x3c*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x3d*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x3e*/ XED_ILD_HASMODRM_UNDEF,
        /*opcode 0x3f*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x40*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x41*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x42*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x43*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x44*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x45*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x46*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x47*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x48*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x49*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x4a*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x4b*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x4c*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x4d*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x4e*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x4f*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x50*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x51*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x52*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x53*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x54*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x55*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x56*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x57*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x58*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x59*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x5a*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x5b*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x5c*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x5d*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x5e*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x5f*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x60*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x61*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x62*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x63*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x64*/ XED_ILD_HASMODRM_UNDEF,
        /*opcode 0x65*/ XED_ILD_HASMODRM_UNDEF,
        /*opcode 0x66*/ XED_ILD_HASMODRM_UNDEF,
        /*opcode 0x67*/ XED_ILD_HASMODRM_UNDEF,
        /*opcode 0x68*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x69*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x6a*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x6b*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x6c*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x6d*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x6e*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x6f*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x70*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x71*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x72*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x73*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x74*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x75*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x76*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x77*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x78*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x79*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x7a*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x7b*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x7c*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x7d*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x7e*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x7f*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x80*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x81*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x82*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x83*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x84*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x85*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x86*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x87*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x88*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x89*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x8a*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x8b*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x8c*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x8d*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x8e*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x8f*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x90*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x91*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x92*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x93*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x94*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x95*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x96*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x97*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x98*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x99*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x9a*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x9b*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x9c*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x9d*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x9e*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x9f*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xa0*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xa1*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xa2*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xa3*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xa4*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xa5*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xa6*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xa7*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xa8*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xa9*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xaa*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xab*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xac*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xad*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xae*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xaf*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xb0*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xb1*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xb2*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xb3*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xb4*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xb5*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xb6*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xb7*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xb8*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xb9*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xba*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xbb*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xbc*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xbd*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xbe*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xbf*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xc0*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xc1*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xc2*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xc3*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xc4*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xc5*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xc6*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xc7*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xc8*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xc9*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xca*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xcb*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xcc*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xcd*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xce*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xcf*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xd0*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xd1*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xd2*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xd3*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xd4*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xd5*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xd6*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xd7*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xd8*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xd9*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xda*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xdb*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xdc*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xdd*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xde*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xdf*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xe0*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xe1*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xe2*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xe3*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xe4*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xe5*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xe6*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xe7*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xe8*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xe9*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xea*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xeb*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xec*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xed*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xee*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xef*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xf0*/ XED_ILD_HASMODRM_UNDEF,
        /*opcode 0xf1*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xf2*/ XED_ILD_HASMODRM_UNDEF,
        /*opcode 0xf3*/ XED_ILD_HASMODRM_UNDEF,
        /*opcode 0xf4*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xf5*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xf6*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xf7*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xf8*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xf9*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xfa*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xfb*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xfc*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xfd*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xfe*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xff*/ XED_ILD_HASMODRM_TRUE,
        };

        xed_uint8_t[] has_modrm_map_0x0F = new xed_uint8_t[256] {
        /*opcode 0x0*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x1*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x2*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x3*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x4*/ XED_ILD_HASMODRM_UNDEF,
        /*opcode 0x5*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x6*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x7*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x8*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x9*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xa*/ XED_ILD_HASMODRM_UNDEF,
        /*opcode 0xb*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xc*/ XED_ILD_HASMODRM_UNDEF,
        /*opcode 0xd*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xe*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xf*/ XED_ILD_HASMODRM_UNDEF,
        /*opcode 0x10*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x11*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x12*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x13*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x14*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x15*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x16*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x17*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x18*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x19*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x1a*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x1b*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x1c*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x1d*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x1e*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x1f*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x20*/ XED_ILD_HASMODRM_IGNORE_MOD,
        /*opcode 0x21*/ XED_ILD_HASMODRM_IGNORE_MOD,
        /*opcode 0x22*/ XED_ILD_HASMODRM_IGNORE_MOD,
        /*opcode 0x23*/ XED_ILD_HASMODRM_IGNORE_MOD,
        /*opcode 0x24*/ XED_ILD_HASMODRM_UNDEF,
        /*opcode 0x25*/ XED_ILD_HASMODRM_UNDEF,
        /*opcode 0x26*/ XED_ILD_HASMODRM_UNDEF,
        /*opcode 0x27*/ XED_ILD_HASMODRM_UNDEF,
        /*opcode 0x28*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x29*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x2a*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x2b*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x2c*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x2d*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x2e*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x2f*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x30*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x31*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x32*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x33*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x34*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x35*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x36*/ XED_ILD_HASMODRM_UNDEF,
        /*opcode 0x37*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x38*/ XED_ILD_HASMODRM_UNDEF,
        /*opcode 0x39*/ XED_ILD_HASMODRM_UNDEF,
        /*opcode 0x3a*/ XED_ILD_HASMODRM_UNDEF,
        /*opcode 0x3b*/ XED_ILD_HASMODRM_UNDEF,
        /*opcode 0x3c*/ XED_ILD_HASMODRM_UNDEF,
        /*opcode 0x3d*/ XED_ILD_HASMODRM_UNDEF,
        /*opcode 0x3e*/ XED_ILD_HASMODRM_UNDEF,
        /*opcode 0x3f*/ XED_ILD_HASMODRM_UNDEF,
        /*opcode 0x40*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x41*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x42*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x43*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x44*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x45*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x46*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x47*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x48*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x49*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x4a*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x4b*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x4c*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x4d*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x4e*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x4f*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x50*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x51*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x52*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x53*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x54*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x55*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x56*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x57*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x58*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x59*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x5a*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x5b*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x5c*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x5d*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x5e*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x5f*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x60*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x61*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x62*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x63*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x64*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x65*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x66*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x67*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x68*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x69*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x6a*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x6b*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x6c*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x6d*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x6e*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x6f*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x70*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x71*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x72*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x73*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x74*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x75*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x76*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x77*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x78*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x79*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x7a*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x7b*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x7c*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x7d*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x7e*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x7f*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x80*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x81*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x82*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x83*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x84*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x85*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x86*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x87*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x88*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x89*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x8a*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x8b*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x8c*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x8d*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x8e*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x8f*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0x90*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x91*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x92*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x93*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x94*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x95*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x96*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x97*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x98*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x99*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x9a*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x9b*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x9c*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x9d*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x9e*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0x9f*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xa0*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xa1*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xa2*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xa3*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xa4*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xa5*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xa6*/ XED_ILD_HASMODRM_IGNORE_MOD,
        /*opcode 0xa7*/ XED_ILD_HASMODRM_IGNORE_MOD,
        /*opcode 0xa8*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xa9*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xaa*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xab*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xac*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xad*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xae*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xaf*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xb0*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xb1*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xb2*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xb3*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xb4*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xb5*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xb6*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xb7*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xb8*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xb9*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xba*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xbb*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xbc*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xbd*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xbe*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xbf*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xc0*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xc1*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xc2*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xc3*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xc4*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xc5*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xc6*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xc7*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xc8*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xc9*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xca*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xcb*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xcc*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xcd*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xce*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xcf*/ XED_ILD_HASMODRM_FALSE,
        /*opcode 0xd0*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xd1*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xd2*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xd3*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xd4*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xd5*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xd6*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xd7*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xd8*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xd9*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xda*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xdb*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xdc*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xdd*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xde*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xdf*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xe0*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xe1*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xe2*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xe3*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xe4*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xe5*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xe6*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xe7*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xe8*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xe9*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xea*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xeb*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xec*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xed*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xee*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xef*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xf0*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xf1*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xf2*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xf3*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xf4*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xf5*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xf6*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xf7*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xf8*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xf9*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xfa*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xfb*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xfc*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xfd*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xfe*/ XED_ILD_HASMODRM_TRUE,
        /*opcode 0xff*/ XED_ILD_HASMODRM_TRUE,
        };
    }
}