// This file was automatically generated from IFCDOC at www.buildingsmart-tech.org.
// IFC content is copyright (C) 1996-2018 BuildingSMART International Ltd.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcProductExtension;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcSharedBldgElements
{
	[Guid("ac862bc5-cee0-4511-a81b-28bd751b24c8")]
	public partial class IfcBuildingSystem : IfcSystem
	{
		[DataMember(Order=0)] 
		[XmlAttribute]
		IfcBuildingSystemTypeEnum? _PredefinedType;
	
		[DataMember(Order=1)] 
		[XmlAttribute]
		IfcLabel? _LongName;
	
	
		public IfcBuildingSystem()
		{
		}
	
		public IfcBuildingSystem(IfcGloballyUniqueId __GlobalId, IfcOwnerHistory __OwnerHistory, IfcLabel? __Name, IfcText? __Description, IfcLabel? __ObjectType, IfcBuildingSystemTypeEnum? __PredefinedType, IfcLabel? __LongName)
			: base(__GlobalId, __OwnerHistory, __Name, __Description, __ObjectType)
		{
			this._PredefinedType = __PredefinedType;
			this._LongName = __LongName;
		}
	
		[Description("Predefined types of distribution systems.")]
		public IfcBuildingSystemTypeEnum? PredefinedType { get { return this._PredefinedType; } set { this._PredefinedType = value;} }
	
		[Description(@"Long name for a building system, used for informal purposes. It should be used, if available, in conjunction with the inherited <em>Name</em> attribute.
	<blockquote class=""note"">NOTE&nbsp; In many scenarios the <em>Name</em> attribute refers to the short name or number of a building system, and the <em>LongName</em> refers to a descriptive name.
	</blockquote>")]
		public IfcLabel? LongName { get { return this._LongName; } set { this._LongName = value;} }
	
	
	}
	
}
