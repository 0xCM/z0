// //-----------------------------------------------------------------------------
// // Copyright   :  (c) Chris Moore, 2020
// // License     :  MIT
// //-----------------------------------------------------------------------------
// namespace Z0.Asm
// {
//     public interface IAsmFxSink
//     {
//         void Deposit(in Instruction src);

//         Mnemonic Kind {get;}
//     }

//     public interface IAsmFxSink<M> : IAsmFxSink
//         where M : unmanaged, IInstructionModel
//     {
//         M Model
//             => default;

//         Mnemonic IAsmFxSink.Kind
//             => Model.Mnemonic;
//     }

//     public interface IAsmFxSink<F,M> : IAsmFxSink<M>
//         where F : struct, IAsmFxSink<F,M>
//         where M : unmanaged, IInstructionModel
//     {

//     }
// }