using System;

namespace PlayScript
{
	public interface IDynamicClass
	{

		dynamic __GetDynamicValue(string name);

		void __SetDynamicValue(string name, object value);
		
		bool __HasDynamicValue(string name);

		_root.Array __GetDynamicNames();

	}
}

