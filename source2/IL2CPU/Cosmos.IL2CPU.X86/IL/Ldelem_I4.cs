using System;

namespace Cosmos.IL2CPU.X86.IL
{
    [Cosmos.IL2CPU.OpCode( ILOpCode.Code.Ldelem_I4 )]
    public class Ldelem_I4 : ILOp
    {
        public Ldelem_I4( Cosmos.Compiler.Assembler.Assembler aAsmblr )
            : base( aAsmblr )
        {
        }

        public override void Execute( MethodInfo aMethod, ILOpCode aOpCode )
        {
            Ldelem_Ref.Assemble( Assembler, 4 );
        }


        // using System;
        // using System.Collections.Generic;
        // using System.IO;
        // 
        // 
        // using CPU = Cosmos.Compiler.Assembler.X86;
        // using CPUx86 = Cosmos.Compiler.Assembler.X86;
        // 
        // namespace Cosmos.IL2CPU.IL.X86 {
        // 	[OpCode(OpCodeEnum.Ldelem_I4)]
        // 	public class Ldelem_I4: Op {
        // 
        //         //public static void ScanOp(ILReader aReader, MethodInformation aMethodInfo, SortedList<string, object> aMethodData)
        //         //{
        //         //    Engine.RegisterType(typeof(int));
        //         //}
        // 
        //         public Ldelem_I4(ILReader aReader, MethodInformation aMethodInfo)
        // 			: base(aReader, aMethodInfo) {
        // 		}
        // 
        // 		public override void DoAssemble() {
        // 			Ldelem_Ref.Assemble(Assembler, 4);
        // 		}
        // 	}
        // }

    }
}