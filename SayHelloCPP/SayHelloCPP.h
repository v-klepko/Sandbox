#pragma once

using namespace System;

namespace SayHelloCPP {
	public ref class SayHello
	{
		public:
			String^ Say()
			{
				return "Hello from C++/CLI";
			}
	};
}
