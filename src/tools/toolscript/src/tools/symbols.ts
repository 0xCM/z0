export interface Sym<T>
{
    Name : T
}

export type Plus = Sym<'+'>

export type Star = Sym<'*'>

export type Amp = Sym<'&'>

export type Sub = Sym<'-'>

export type Mul = Sym<'*'>

export type N0 = Sym<'0'>

export type N1 = Sym<'1'>

export type N2 = Sym<'2'>

export type N3 = Sym<'3'>

export type N4 = Sym<'4'>

export type N5 = Sym<'5'>

export type N6 = Sym<'6'>

export type N7 = Sym<'7'>

export type Digit = N0 | N1 | N2 | N3 | N4 | N5 | N6 | N7


