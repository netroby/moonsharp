﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MoonSharp.Interpreter.Execution;

namespace MoonSharp.Interpreter.Tree.Statements
{
	class LabelStatement : Statement
	{
		public string Label { get; private set; }


		public LabelStatement(ScriptLoadingContext lcontext)
			: base(lcontext)
		{
			CheckTokenType(lcontext, TokenType.DoubleColon);
			Token name = CheckTokenType(lcontext, TokenType.Name);
			CheckTokenType(lcontext, TokenType.DoubleColon);

			Label = name.Text;
		}


		public override void Compile(Execution.VM.ByteCode bc)
		{
			throw new NotImplementedException();
		}
	}
}

