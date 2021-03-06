﻿using System;
using System.ComponentModel;

namespace BytecodeApi.UI.Converters
{
	/// <summary>
	/// Specifies the method that is used to convert <see cref="Enum" /> values.
	/// </summary>
	public enum EnumConverterMethod
	{
		/// <summary>
		/// Returns the equivalent <see cref="string" /> representation of the <see cref="Enum" /> value.
		/// </summary>
		String,
		/// <summary>
		/// Returns the <see cref="DescriptionAttribute.Description" /> of the <see langword="Enum" /> value, or <see langword="null" />, if the attribute was not found.
		/// </summary>
		Description,
		/// <summary>
		/// Returns the <see cref="DescriptionAttribute.Description" /> of the <see langword="Enum" /> value.
		/// If the attribute was not found, the <see cref="string" /> representation of the <see langword="Enum" /> value is returned.
		/// </summary>
		DescriptionOrString,
		/// <summary>
		/// Returns the equivalent <see cref="int" /> value of the <see cref="Enum" /> value.
		/// </summary>
		Value
	}
}