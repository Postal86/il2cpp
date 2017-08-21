﻿using System.Collections.Generic;
using dnlib.DotNet;

namespace il2cpp
{
	internal class GenericArgs
	{
		public IList<TypeSig> GenArgs;
		public bool HasGenArgs => GenArgs != null && GenArgs.Count > 0;
	}

	internal class TypeX : GenericArgs
	{
		// 当前环境
		private readonly Il2cppContext Context;

		// 类型定义的全名
		public readonly string DefFullName;
		// 全局唯一的名称键
		private string NameKey;

		// 继承的类型
		private readonly HashSet<TypeX> DerivedTypes = new HashSet<TypeX>();
		public bool IsDerivedTypesChanged { get; private set; }

		// 是否实例化过
		public OnceBool IsInstantiated;

		internal TypeX(Il2cppContext context, TypeDef tyDef)
		{
			Context = context;
			DefFullName = tyDef.FullName;
		}

		public string GetNameKey()
		{
			if (NameKey == null)
			{
				//!
			}
			return NameKey;
		}

		public HashSet<TypeX> GetDerivedTypes()
		{
			return DerivedTypes;
		}

		public void AddDerivedType(TypeX tyX)
		{
			DerivedTypes.Add(tyX);
			IsDerivedTypesChanged = true;
		}
	}
}
