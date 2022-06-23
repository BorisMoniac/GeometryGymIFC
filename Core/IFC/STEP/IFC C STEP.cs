// MIT License
// Copyright (c) 2016 Geometry Gym Pty Ltd

// Permission is hereby granted, free of charge, to any person obtaining a copy of this software 
// and associated documentation files (the "Software"), to deal in the Software without restriction, 
// including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, 
// and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, 
// subject to the following conditions:

// The above copyright notice and this permission notice shall be included in all copies or substantial 
// portions of the Software.

// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT 
// LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. 
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE 
// SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Reflection;
using System.IO;
using System.ComponentModel;
using System.Linq;

using GeometryGym.STEP;


namespace GeometryGym.Ifc
{
	public partial class IfcCableCarrierFitting
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + (release < ReleaseVersion.IFC4 ? "" : (mPredefinedType == IfcCableCarrierFittingTypeEnum.NOTDEFINED ? ",$" : ",." + mPredefinedType.ToString() + ".")); }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			if (release != ReleaseVersion.IFC2x3)
			{
				string s = ParserSTEP.StripField(str, ref pos, len);
				if (s.StartsWith("."))
					Enum.TryParse<IfcCableCarrierFittingTypeEnum>(s.Replace(".", ""), true, out mPredefinedType);
			}
		}
	}
	public partial class IfcCableCarrierFittingType
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + ",." + mPredefinedType.ToString() + "."; }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			string s = ParserSTEP.StripField(str, ref pos, len);
			if (s.StartsWith("."))
				Enum.TryParse<IfcCableCarrierFittingTypeEnum>(s.Replace(".", ""), true, out mPredefinedType);
		}
	}
	public partial class IfcCableCarrierSegment
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + (release < ReleaseVersion.IFC4 ? "" : (mPredefinedType == IfcCableCarrierSegmentTypeEnum.NOTDEFINED ? ",$" : ",." + mPredefinedType.ToString() + ".")); }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			if (release != ReleaseVersion.IFC2x3)
			{
				string s = ParserSTEP.StripField(str, ref pos, len);
				if (s.StartsWith("."))
					Enum.TryParse<IfcCableCarrierSegmentTypeEnum>(s.Replace(".", ""), true, out mPredefinedType);
			}
		}
	}
	public partial class IfcCableCarrierSegmentType
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + ",." + mPredefinedType.ToString() + "."; }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			string s = ParserSTEP.StripField(str, ref pos, len);
			if (s.StartsWith("."))
				Enum.TryParse<IfcCableCarrierSegmentTypeEnum>(s.Replace(".", ""), true, out mPredefinedType);
		}
	}
	public partial class IfcCableFitting
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + (release < ReleaseVersion.IFC4 ? "" : (mPredefinedType == IfcCableFittingTypeEnum.NOTDEFINED ? ",$" : ",." + mPredefinedType.ToString() + ".")); }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			if (release != ReleaseVersion.IFC2x3)
			{
				string s = ParserSTEP.StripField(str, ref pos, len);
				if (s.StartsWith("."))
					Enum.TryParse<IfcCableFittingTypeEnum>(s.Replace(".", ""), true, out mPredefinedType);
			}
		}
	}
	public partial class IfcCableFittingType
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + ",." + mPredefinedType.ToString() + "."; }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			string s = ParserSTEP.StripField(str, ref pos, len);
			if (s.StartsWith("."))
				Enum.TryParse<IfcCableFittingTypeEnum>(s.Replace(".", ""), true, out mPredefinedType);
		}
	}
	public partial class IfcCableSegment
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + (release < ReleaseVersion.IFC4 ? "" : ",." + mPredefinedType.ToString() + "."); }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			if (release != ReleaseVersion.IFC2x3)
			{
				string s = ParserSTEP.StripField(str, ref pos, len);
				if (s.StartsWith("."))
					Enum.TryParse<IfcCableSegmentTypeEnum>(s.Replace(".", ""), true, out mPredefinedType);
			}
		}
	}
	public partial class IfcCableSegmentType
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + ",." + mPredefinedType.ToString() + "."; }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			string s = ParserSTEP.StripField(str, ref pos, len);
			if (s.StartsWith("."))
				Enum.TryParse<IfcCableSegmentTypeEnum>(s.Replace(".", ""), true, out mPredefinedType);
		}
	}
	public partial class IfcCaissonFoundation
	{
		protected override string BuildStringSTEP(ReleaseVersion release)
		{
			return base.BuildStringSTEP(release) +
			(mPredefinedType == IfcCaissonFoundationTypeEnum.NOTDEFINED ? ",$" : ",." + mPredefinedType.ToString() + ".");
		}
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			string s = ParserSTEP.StripField(str, ref pos, len);
			if (s.StartsWith("."))
				Enum.TryParse<IfcCaissonFoundationTypeEnum>(s.Replace(".", ""), true, out mPredefinedType);
		}
	}
	public partial class IfcCaissonFoundationType
	{
		protected override string BuildStringSTEP(ReleaseVersion release)
		{
			return base.BuildStringSTEP(release) +
			",." + mPredefinedType.ToString() + ".";
		}
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			string s = ParserSTEP.StripField(str, ref pos, len);
			if (s.StartsWith("."))
				Enum.TryParse<IfcCaissonFoundationTypeEnum>(s.Replace(".", ""), true, out mPredefinedType);
		}
	}
	public partial class IfcCalendarDate
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return mDayComponent + "," + mMonthComponent + "," + mYearComponent; }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			mDayComponent = ParserSTEP.StripInt(str, ref pos, len);
			mMonthComponent = ParserSTEP.StripInt(str, ref pos, len);
			mYearComponent = ParserSTEP.StripInt(str, ref pos, len);
		}
	}
	public partial class IfcCartesianPoint
	{
		protected override string BuildStringSTEP(ReleaseVersion release)
		{
			Tuple<double, double, double> coordinates = SerializeCoordinates;
			string result = "(" + ParserSTEP.DoubleToString(coordinates.Item1) + "," + ParserSTEP.DoubleToString(coordinates.Item2);
			if (double.IsNaN(coordinates.Item3))
				return result + ")";
			return result + "," + ParserSTEP.DoubleToString(coordinates.Item3) + ")";
		}
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			string s = str.Trim();
			if (s[0] == '(')
			{
				string[] fields = s.Substring(1, s.Length - 2).Split(",".ToCharArray());
				if (fields != null && fields.Length > 0)
				{
					mCoordinateX = ParserSTEP.ParseDouble(fields[0]);
					if (double.IsNaN(mCoordinateX))
						mCoordinateX = 0;
					if (fields.Length > 1)
					{
						mCoordinateY = ParserSTEP.ParseDouble(fields[1]);
						if (fields.Length > 2)
							mCoordinateZ = ParserSTEP.ParseDouble(fields[2]);
					}
				}
			}
		}
	}
	public partial class IfcCartesianPointList2D
	{
		protected override string BuildStringSTEP(ReleaseVersion release)
		{
			return "(" + string.Join(",", mCoordList.Select(x => "(" + formatLength(x.Item1) + "," + formatLength(x.Item2) + ")")) + ")" +
				(release < ReleaseVersion.IFC4X1 ? "" : (mTagList == null || mTagList.Count == 0 ? ",$" : ",(" + string.Join(",", mTagList.Select(x=> (string.IsNullOrEmpty(x) ? "$" : "'" + ParserIfc.Encode(x) + "'"))) + ")" ));
		}
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			if(release < ReleaseVersion.IFC4X1)
				mCoordList = ParserSTEP.SplitListDoubleTuple(str); 
			else
			{
				string s = ParserSTEP.StripField(str, ref pos, len);
				mCoordList = ParserSTEP.SplitListDoubleTuple(s); 
				s = ParserSTEP.StripField(str, ref pos, len);
				if (!string.IsNullOrEmpty(s) && s != "$")
				{
					List<string> lst = ParserSTEP.SplitLineFields(s.Substring(1, s.Length - 2));
					for (int icounter = 0; icounter < lst.Count; icounter++)
					{
						string field = lst[icounter];
						if (field.Length > 2)
							mTagList.Add(ParserIfc.Decode(field.Substring(1, field.Length - 2)));
						else
							mTagList.Add(null);
					}
				}
			}
		}
	}
	public partial class IfcCartesianPointList3D
	{
		internal override void WriteStepLine(TextWriter textWriter, ReleaseVersion release)
		{
			WriteStepLineWorkerPrefix(textWriter);

			var first = mCoordList[0];

			textWriter.Write("((");
			textWriter.Write(formatLength(first.Item1));
			textWriter.Write(",");
			textWriter.Write(formatLength(first.Item2));
			textWriter.Write(",");
			textWriter.Write(formatLength(first.Item3));

			foreach (var coord in mCoordList.Skip(1))
			{
				textWriter.Write("),(");
				textWriter.Write(formatLength(coord.Item1));
				textWriter.Write(",");
				textWriter.Write(formatLength(coord.Item2));
				textWriter.Write(",");
				textWriter.Write(formatLength(coord.Item3));
			}
			textWriter.Write("))");
			
			if(release >= ReleaseVersion.IFC4X1)
				textWriter.Write(mTagList == null || mTagList.Count == 0 ? ",$" : ",(" + string.Join(",", mTagList.Select(x => (string.IsNullOrEmpty(x) ? "$" : "'" + ParserIfc.Encode(x) + "'"))) + ")");

			WriteStepLineWorkerSuffix(textWriter);
		}
		protected override string BuildStringSTEP(ReleaseVersion release)
		{
			StringBuilder stringBuilder = new StringBuilder();
			var first = mCoordList[0];
			stringBuilder.Append("((");
			stringBuilder.Append(formatLength(first.Item1));
			stringBuilder.Append(",");
			stringBuilder.Append(formatLength(first.Item2));
			stringBuilder.Append(",");
			stringBuilder.Append(formatLength(first.Item3));

			foreach (var coord in mCoordList.Skip(1))
			{
				stringBuilder.Append("),(");
				stringBuilder.Append(formatLength(coord.Item1));
				stringBuilder.Append(",");
				stringBuilder.Append(formatLength(coord.Item2));
				stringBuilder.Append(",");
				stringBuilder.Append(formatLength(coord.Item3));
			}
			stringBuilder.Append("))");
			return stringBuilder.ToString() + 
				(release < ReleaseVersion.IFC4X1 ? "" : (mTagList == null || mTagList.Count == 0 ? ",$" : ",(" + string.Join(",", mTagList.Select(x => (string.IsNullOrEmpty(x) ? "$" : "'" + ParserIfc.Encode(x) + "'"))) + ")")); 
		}
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			if (release < ReleaseVersion.IFC4X1)
				mCoordList.AddRange(ParserSTEP.SplitListDoubleTriple(str));
			else
			{
				mCoordList.AddRange(ParserSTEP.StripListTripleDouble(str, ref pos, len));
				string s = ParserSTEP.StripField(str, ref pos, len);
				if (!string.IsNullOrEmpty(s) && s != "$")
				{
					List<string> lst = ParserSTEP.SplitLineFields(s.Substring(1, s.Length - 2));
					for (int icounter = 0; icounter < lst.Count; icounter++)
					{
						string field = lst[icounter];
						if (field.Length > 2)
							mTagList.Add(ParserIfc.Decode(field.Substring(1, field.Length - 2)));
						else
							mTagList.Add(null);
					}
				}
			}
		}
	}
	public abstract partial class IfcCartesianTransformationOperator
	{
		protected override string BuildStringSTEP(ReleaseVersion release)
		{
			return ParserSTEP.LinkToString(mAxis1) + "," + ParserSTEP.LinkToString(mAxis2) + "," +
				ParserSTEP.LinkToString(mLocalOrigin) + "," + ParserSTEP.DoubleOptionalToString(mScale);
		}
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			mAxis1 = ParserSTEP.StripLink(str, ref pos, len);
			mAxis2 = ParserSTEP.StripLink(str, ref pos, len);
			mLocalOrigin = ParserSTEP.StripLink(str, ref pos, len);
			Scale = ParserSTEP.StripDouble(str, ref pos, len);
		}
	}
	public partial class IfcCartesianTransformationOperator2DnonUniform
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + "," + ParserSTEP.DoubleOptionalToString(mScale2); }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			Scale2 = ParserSTEP.StripDouble(str, ref pos, len);
		}
	}
	public partial class IfcCartesianTransformationOperator3D
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + "," + ParserSTEP.LinkToString(mAxis3); }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			mAxis3 = ParserSTEP.StripLink(str, ref pos, len);
		}
	}
	public partial class IfcCartesianTransformationOperator3DnonUniform
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + "," + ParserSTEP.DoubleOptionalToString(mScale2) + "," + ParserSTEP.DoubleOptionalToString(mScale3); }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			Scale2 = ParserSTEP.StripDouble(str, ref pos, len);
			Scale3 = ParserSTEP.StripDouble(str, ref pos, len);
		}
	}
	public partial class IfcCenterLineProfileDef
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + "," + ParserSTEP.DoubleToString(mThickness); }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			mThickness = ParserSTEP.StripDouble(str, ref pos, len);
		}
	}
	public partial class IfcChamferEdgeFeature
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + "," + ParserSTEP.DoubleOptionalToString(mWidth) + "," + ParserSTEP.DoubleOptionalToString(mHeight); }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			mWidth = ParserSTEP.StripDouble(str, ref pos, len);
			mHeight = ParserSTEP.StripDouble(str, ref pos, len);
		}
	}
	public partial class IfcChiller
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + (release < ReleaseVersion.IFC4 ? "" : (mPredefinedType == IfcChillerTypeEnum.NOTDEFINED ? ",$" : ",." + mPredefinedType.ToString() + ".")); }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			if (release != ReleaseVersion.IFC2x3)
			{
				string s = ParserSTEP.StripField(str, ref pos, len);
				if (s.StartsWith("."))
					Enum.TryParse<IfcChillerTypeEnum>(s.Replace(".", ""), true, out mPredefinedType);
			}
		}
	}
	public partial class IfcChillerType
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + ",." + mPredefinedType.ToString() + "."; }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			string s = ParserSTEP.StripField(str, ref pos, len);
			if (s.StartsWith("."))
				Enum.TryParse<IfcChillerTypeEnum>(s.Replace(".", ""), true, out mPredefinedType);
		}
	}
	public partial class IfcChimney
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + (release < ReleaseVersion.IFC4 ? "" : (mPredefinedType == IfcChimneyTypeEnum.NOTDEFINED ? ",$" : ",." + mPredefinedType.ToString() + ".")); }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			if (release != ReleaseVersion.IFC2x3)
			{
				string s = ParserSTEP.StripField(str, ref pos, len);
				if (s.StartsWith("."))
					Enum.TryParse<IfcChimneyTypeEnum>(s.Replace(".", ""), true, out mPredefinedType);
			}
		}
	}
	public partial class IfcChimneyType
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + ",." + mPredefinedType.ToString() + "."; }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			string s = ParserSTEP.StripField(str, ref pos, len);
			if (s.StartsWith("."))
				Enum.TryParse<IfcChimneyTypeEnum>(s.Replace(".", ""), true, out mPredefinedType);
		}
	}
	public partial class IfcCircle
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + "," + formatLength(mRadius); }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			mRadius = ParserSTEP.StripDouble(str, ref pos, len);
		}
	}
	public partial class IfcCircleHollowProfileDef
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + (mWallThickness < mDatabase.Tolerance ? "" : "," + formatLength(mWallThickness)); }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			mWallThickness = ParserSTEP.StripDouble(str, ref pos, len);
		}
	}
	public partial class IfcCircleProfileDef
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + "," + formatLength(mRadius); }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			mRadius = ParserSTEP.StripDouble(str, ref pos, len);
		}
	}
	public partial class IfcCircularArcSegment2D
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + "," + formatLength(mRadius) + "," + ParserSTEP.BoolToString(mIsCCW); }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			Radius = ParserSTEP.StripDouble(str, ref pos, len);
			mIsCCW = ParserSTEP.StripBool(str, ref pos, len);
		}
	}
	public partial class IfcClassification
	{
		protected override string BuildStringSTEP(ReleaseVersion release)
		{
			string tokens = "$";
			if (mReferenceTokens.Count > 0)
				tokens = "('" + string.Join("','", mReferenceTokens) + "')";
			bool older = mDatabase.Release <= ReleaseVersion.IFC2x3;
			string result = (mSource == "$" ? (older ? "'Unknown'," : "$,") : "'" + mSource + "',") +
				(mEdition == "$" ? (older ? "'Unknown'," : "$,") : "'" + mEdition + "',") + (older ? ParserSTEP.LinkToString(mEditionDateSS) : IfcDate.STEPAttribute(mEditionDate)) +
				",'" + mName + (older ? "'" : (mDescription == "$" ? "',$," : "','" + mDescription + "',") + (mSpecification == "$" ? "$," : "'" + mSpecification + "',") + tokens);
			return result;
		}
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			mSource = ParserSTEP.StripString(str, ref pos, len);
			mEdition = ParserSTEP.StripString(str, ref pos, len);
			if (release <= ReleaseVersion.IFC2x3)
			{
				mEditionDateSS = ParserSTEP.StripLink(str, ref pos, len);
				mName = ParserSTEP.StripString(str, ref pos, len);
			}
			else
			{
				mEditionDate = IfcDateTime.ParseSTEP(ParserSTEP.StripField(str, ref pos, len));
				mName = ParserSTEP.StripString(str, ref pos, len);
				mDescription = ParserSTEP.StripString(str, ref pos, len);
				mSpecification = ParserSTEP.StripString(str, ref pos, len);
				mReferenceTokens = ParserSTEP.SplitListStrings(ParserSTEP.StripField(str, ref pos, len));
			}
		}
	}
	public partial class IfcClassificationItem
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return ParserSTEP.LinkToString(mNotation) + "," + ParserSTEP.LinkToString(mItemOf) + "," + mTitle; }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			mNotation = ParserSTEP.StripLink(str, ref pos, len);
			mItemOf = ParserSTEP.StripLink(str, ref pos, len);
			mTitle = ParserSTEP.StripString(str, ref pos, len);
		}
	}
	public partial class IfcClassificationItemRelationship
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return mSource + "," + mEdition + "," + ParserSTEP.LinkToString(mEditionDate) + "," + mName; }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			mSource = ParserSTEP.StripString(str, ref pos, len);
			mEdition = ParserSTEP.StripString(str, ref pos, len);
			mEditionDate = ParserSTEP.StripLink(str, ref pos, len);
			mName = ParserSTEP.StripString(str, ref pos, len);
		}
	}
	public partial class IfcClassificationNotation
	{
		protected override string BuildStringSTEP(ReleaseVersion release)
		{
			return "(" + string.Join(",", mNotationFacets.Select(x=>"#" + mNotationFacets)) + ")";
		}
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary) { mNotationFacets = ParserSTEP.StripListLink(str, ref pos, len); }
	}
	public partial class IfcClassificationNotationFacet
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return mNotationValue; }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary) { mNotationValue = ParserSTEP.StripString(str, ref pos, len); }
	}
	public partial class IfcClassificationReference
	{
		protected override string BuildStringSTEP(ReleaseVersion release) 
		{
			if (release < ReleaseVersion.IFC4)
				return base.BuildStringSTEP(release) + (ReferencedSource is IfcClassification ? "," + ParserSTEP.ObjToLinkString(ReferencedSource) : ",$");
			return base.BuildStringSTEP(release) + "," + ParserSTEP.ObjToLinkString(ReferencedSource) + 
				(mDescription == "$" ? ",$" : ",'" + mDescription + "'") + (mSort == "$" ? ",$" : ",'" + mSort + "'"); 
		}
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			ReferencedSource = dictionary[ParserSTEP.StripLink(str, ref pos, len)] as IfcClassificationReferenceSelect;
			if (release > ReleaseVersion.IFC2x3)
			{
				mDescription = ParserSTEP.StripString(str, ref pos, len);
				mSort = ParserSTEP.StripString(str, ref pos, len);
			}
		}
	}
	public partial class IfcClothoid
	{
		protected override string BuildStringSTEP(ReleaseVersion release)
		{
			return base.BuildStringSTEP(release) + "," + ParserSTEP.DoubleToString(mClothoidConstant);
		}
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			ClothoidConstant = ParserSTEP.StripDouble(str, ref pos, len);
		}
	}
	public partial class IfcCoil
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + (release < ReleaseVersion.IFC4 ? "" : (mPredefinedType == IfcCoilTypeEnum.NOTDEFINED ? ",$" : ",." + mPredefinedType.ToString() + ".")); }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			if (release != ReleaseVersion.IFC2x3)
			{
				string s = ParserSTEP.StripField(str, ref pos, len);
				if (s.StartsWith("."))
					Enum.TryParse<IfcCoilTypeEnum>(s.Replace(".", ""), true, out mPredefinedType);
			}
		}
	}
	public partial class IfcCoilType
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + ",." + mPredefinedType.ToString() + "."; }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			string s = ParserSTEP.StripField(str, ref pos, len);
			if (s.StartsWith("."))
				Enum.TryParse<IfcCoilTypeEnum>(s.Replace(".", ""), true, out mPredefinedType);
		}
	}
	public partial class IfcColourRgb
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + "," + ParserSTEP.DoubleToString(mRed) + "," + ParserSTEP.DoubleToString(mGreen) + "," + ParserSTEP.DoubleToString(mBlue); }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			mRed = ParserSTEP.StripDouble(str, ref pos, len);
			mGreen = ParserSTEP.StripDouble(str, ref pos, len);
			mBlue = ParserSTEP.StripDouble(str, ref pos, len);
		}
	}
	public partial class IfcColourRgbList
	{
		protected override string BuildStringSTEP(ReleaseVersion release)
		{
			return "(" + 
				string.Join(",", mColourList.Select(x=> "(" + ParserSTEP.DoubleToString(x.Item1) + "," + ParserSTEP.DoubleToString(x.Item2) + "," + ParserSTEP.DoubleToString(x.Item3) + ")")) + ")";
		}
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary) 
		{
			mColourList.AddRange(ParserSTEP.SplitListDoubleTriple(str));
		}
	}
	public abstract partial class IfcColourSpecification
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return (mName == "$" ? "$" : "'" + mName + "'"); }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			mName = ParserSTEP.StripString(str, ref pos, len);
		}
	}
	public partial class IfcColumn
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + (release < ReleaseVersion.IFC4 ? "" : (mPredefinedType == IfcColumnTypeEnum.NOTDEFINED ? ",$" : ",." + mPredefinedType.ToString() + ".")); }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			if (release != ReleaseVersion.IFC2x3)
			{
				string s = ParserSTEP.StripField(str, ref pos, len);
				if (s[0] == '.')
					Enum.TryParse<IfcColumnTypeEnum>(s.Substring(1, s.Length - 2), out mPredefinedType);
			}
		}
	}
	public partial class IfcColumnType
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + ",." + mPredefinedType.ToString() + "."; }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			string s = ParserSTEP.StripField(str, ref pos, len);
			if (s[0] == '.')
				Enum.TryParse<IfcColumnTypeEnum>(s.Substring(1, s.Length - 2), out mPredefinedType);
		}
	}
	public partial class IfcComplexProperty
	{
		protected override string BuildStringSTEP(ReleaseVersion release)
		{
			return base.BuildStringSTEP(release) + ",'" + ParserIfc.Encode(mUsageName) + 
				(mHasProperties.Values.Count == 0 ? "',()" : "',(#" + string.Join(",#", mHasProperties.Values.Select(x=>x.StepId)) + ")");
		}
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			mUsageName = ParserSTEP.StripString(str, ref pos, len);
			foreach(int i in ParserSTEP.StripListLink(str, ref pos, len))
			{
				IfcProperty property = dictionary[i] as IfcProperty;
				if (property != null)
					addProperty(property);
			}
		}
	}
	public partial class IfcComplexPropertyTemplate
	{
		protected override string BuildStringSTEP(ReleaseVersion release)
		{
			if (release < ReleaseVersion.IFC4)
				return "";
			return base.BuildStringSTEP(release) + (string.IsNullOrEmpty(mUsageName) ? ",$," : ",'" + ParserIfc.Encode(mUsageName) + "',") + (mTemplateType == IfcComplexPropertyTemplateTypeEnum.NOTDEFINED ? ",$," : ",." + mTemplateType + ".,") +
				(mHasPropertyTemplates.Count == 0 ? "$" : "(#" + string.Join(",#", mHasPropertyTemplates.Values.Select(x => x.Index)) + ")");
		}
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			mUsageName = ParserIfc.Decode(ParserSTEP.StripString(str, ref pos, len));
			string field = ParserSTEP.StripField(str, ref pos, len);
			if (field.StartsWith("."))
				Enum.TryParse<IfcComplexPropertyTemplateTypeEnum>(field.Replace(".", ""), true, out mTemplateType);
			foreach (IfcPropertyTemplate propertyTemplate in ParserSTEP.StripListLink(str, ref pos, len).Select(x => dictionary[x] as IfcPropertyTemplate))
				AddPropertyTemplate(propertyTemplate);
		}
	}
	public partial class IfcCompositeCurve
	{
		protected override string BuildStringSTEP(ReleaseVersion release)
		{
			return "(" + string.Join(",", Segments.ConvertAll(x=>"#" + x.Index)) + ")," + ParserIfc.LogicalToString(mSelfIntersect);
		}
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			if(!(release == ReleaseVersion.IFC4X3_RC2 && (this is IfcGradientCurve || this is IfcSegmentedReferenceCurve)))
				Segments.AddRange(ParserSTEP.StripListLink(str, ref pos, len).ConvertAll(x=>dictionary[x] as IfcSegment));
			mSelfIntersect = ParserIfc.StripLogical(str, ref pos, len);
		}
	}
	public partial class IfcCompositeCurveOnSurface
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + ",#" + mBasisSurface; }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			mBasisSurface = ParserSTEP.StripLink(str, ref pos, len);
		}
	}
	public partial class IfcCompositeCurveSegment
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + "," + ParserSTEP.BoolToString(mSameSense) + ",#" + mParentCurve.StepId; }

		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			mSameSense = ParserSTEP.StripBool(str, ref pos, len);
			mParentCurve = dictionary[ParserSTEP.StripLink(str, ref pos, len)] as IfcCurve;
		}
	}
	public partial class IfcCompositeProfileDef
	{
		protected override string BuildStringSTEP(ReleaseVersion release)
		{
			return base.BuildStringSTEP(release) + ",(#" + String.Join(",#", mProfiles.Select(x=>x.StepId)) + (mLabel == "$" ? "),$" : "),'" + mLabel + "'");
		}
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			mProfiles.AddRange(ParserSTEP.StripListLink(str, ref pos, len).Select(x=>dictionary[x] as IfcProfileDef));
			mLabel = ParserSTEP.StripString(str, ref pos, len);
		}
	}
	public partial class IfcCompressor
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + (release < ReleaseVersion.IFC4 ? "" : (mPredefinedType == IfcCompressorTypeEnum.NOTDEFINED ? ",$" : ",." + mPredefinedType.ToString() + ".")); }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			if (release != ReleaseVersion.IFC2x3)
			{
				string s = ParserSTEP.StripField(str, ref pos, len);
				if (s.StartsWith("."))
					Enum.TryParse<IfcCompressorTypeEnum>(s.Replace(".", ""), true, out mPredefinedType);
			}
		}
	}
	public partial class IfcCompressorType
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + ",." + mPredefinedType.ToString() + "."; }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			string s = ParserSTEP.StripField(str, ref pos, len);
			if (s.StartsWith("."))
				Enum.TryParse<IfcCompressorTypeEnum>(s.Replace(".", ""), true, out mPredefinedType);
		}
	}
	public partial class IfcCommunicationsAppliance
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + (release < ReleaseVersion.IFC4 ? "" : (mPredefinedType == IfcCommunicationsApplianceTypeEnum.NOTDEFINED ? ",$" : ",." + mPredefinedType.ToString() + ".")); }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			if (release != ReleaseVersion.IFC2x3)
			{
				string s = ParserSTEP.StripField(str, ref pos, len);
				if (s.StartsWith("."))
					Enum.TryParse<IfcCommunicationsApplianceTypeEnum>(s.Replace(".", ""), true, out mPredefinedType);
			}
		}
	}
	public partial class IfcCommunicationsApplianceType
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + ",." + mPredefinedType.ToString() + "."; }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			string s = ParserSTEP.StripField(str, ref pos, len);
			if (s.StartsWith("."))
				Enum.TryParse<IfcCommunicationsApplianceTypeEnum>(s.Replace(".", ""), true, out mPredefinedType);
		}
	}
	public partial class IfcCondenser
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + (release < ReleaseVersion.IFC4 ? "" : (mPredefinedType == IfcCondenserTypeEnum.NOTDEFINED ? ",$" : ",." + mPredefinedType.ToString() + ".")); }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			if (release != ReleaseVersion.IFC2x3)
			{
				string s = ParserSTEP.StripField(str, ref pos, len);
				if (s.StartsWith("."))
					Enum.TryParse<IfcCondenserTypeEnum>(s.Replace(".", ""), true, out mPredefinedType);
			}
		}
	}
	public partial class IfcCondenserType
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + ",." + mPredefinedType.ToString() + "."; }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			string s = ParserSTEP.StripField(str, ref pos, len);
			if (s.StartsWith("."))
				Enum.TryParse<IfcCondenserTypeEnum>(s.Replace(".", ""), true, out mPredefinedType);
		}
	}
	public partial class IfcConditionCriterion
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + "," + ParserSTEP.LinkToString(mCriterion) + "," + ParserSTEP.LinkToString(mCriterionDateTime); }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			mCriterion = ParserSTEP.StripLink(str, ref pos, len);
			mCriterionDateTime = ParserSTEP.StripLink(str, ref pos, len);
		}
	}
	public abstract partial class IfcConic
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return ParserSTEP.LinkToString(mPosition); }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary) { mPosition = ParserSTEP.StripLink(str, ref pos, len); }
	}
	public partial class IfcConnectedFaceSet
	{
		protected override string BuildStringSTEP(ReleaseVersion release)
		{
			if (mCfsFaces.Count == 0)
				return "";
			return "(#" + string.Join(",#", CfsFaces.ConvertAll(x => x.Index)) + ")";
		}
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary) 
		{
			List<int> stepIds = ParserSTEP.StripListLink(str, ref pos, len);
			CfsFaces.AddRange(stepIds.ConvertAll(x => dictionary[x] as IfcFace)); }
	}
	public partial class IfcConnectionCurveGeometry
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return ParserSTEP.LinkToString(mCurveOnRelatingElement) + "," + ParserSTEP.LinkToString(mCurveOnRelatedElement); }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			mCurveOnRelatingElement = ParserSTEP.StripLink(str, ref pos, len);
			mCurveOnRelatedElement = ParserSTEP.StripLink(str, ref pos, len);
		}
	}
	public partial class IfcConnectionPointEccentricity
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + "," + ParserSTEP.DoubleOptionalToString(mEccentricityInX) + "," + ParserSTEP.DoubleOptionalToString(mEccentricityInY) + "," + ParserSTEP.DoubleOptionalToString(mEccentricityInZ); }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			mEccentricityInX = ParserSTEP.StripDouble(str, ref pos, len);
			mEccentricityInY = ParserSTEP.StripDouble(str, ref pos, len);
			mEccentricityInZ = ParserSTEP.StripDouble(str, ref pos, len);
		}
	}
	public partial class IfcConnectionPointGeometry
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return ParserSTEP.LinkToString(mPointOnRelatingElement) + "," + ParserSTEP.LinkToString(mPointOnRelatedElement); }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			mPointOnRelatingElement = ParserSTEP.StripLink(str, ref pos, len);
			mPointOnRelatedElement = ParserSTEP.StripLink(str, ref pos, len);
		}
	}
	public partial class IfcConnectionSurfaceGeometry
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return ParserSTEP.LinkToString(mSurfaceOnRelatingElement) + "," + ParserSTEP.LinkToString(mSurfaceOnRelatedElement); }

		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			mSurfaceOnRelatingElement = ParserSTEP.StripLink(str, ref pos, len);
			mSurfaceOnRelatedElement = ParserSTEP.StripLink(str, ref pos, len);
		}
	}
	public partial class IfcConnectionVolumeGeometry
	{
		protected override string BuildStringSTEP(ReleaseVersion release)
		{
			return "#" + mVolumeOnRelatingElement.StepId +
			(mVolumeOnRelatedElement == null ? ",$" : ",#" + mVolumeOnRelatedElement.StepId);
		}
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			VolumeOnRelatingElement = dictionary[ParserSTEP.StripLink(str, ref pos, len)] as IfcSolidOrShell;
			VolumeOnRelatedElement = dictionary[ParserSTEP.StripLink(str, ref pos, len)] as IfcSolidOrShell;
		}
	}
	public abstract partial class IfcConstraint
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return "'" + mName + (mDescription == "$" ? "',$,." : "','" + mDescription + "',.") + mConstraintGrade.ToString() + (mConstraintSource == "$" ? ".,$," : ".,'" + mConstraintSource + "',") + ParserSTEP.LinkToString(mCreatingActor) + "," + (release < ReleaseVersion.IFC4 ? ParserSTEP.LinkToString(mSSCreationTime) : (mCreationTime == "$" ? "$" : "'" + mCreationTime + "'")) + (mUserDefinedGrade == "$" ? ",$" : ",'" + mUserDefinedGrade + "'"); }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			mName = ParserSTEP.StripString(str, ref pos, len);
			mDescription = ParserSTEP.StripString(str, ref pos, len);
			Enum.TryParse<IfcConstraintEnum>(ParserSTEP.StripField(str, ref pos, len).Replace(".", ""), true, out mConstraintGrade);
			mConstraintSource = ParserSTEP.StripString(str, ref pos, len);
			mCreatingActor = ParserSTEP.StripLink(str, ref pos, len);
			if (release < ReleaseVersion.IFC4)
				mSSCreationTime = ParserSTEP.StripLink(str, ref pos, len);
			else
				mCreationTime = ParserSTEP.StripString(str, ref pos, len);
			mUserDefinedGrade = ParserSTEP.StripString(str, ref pos, len);
		}
	}
	public partial class IfcConstructionEquipmentResource
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + (mDatabase.Release < ReleaseVersion.IFC4 ? "" : (mPredefinedType == IfcConstructionEquipmentResourceTypeEnum.NOTDEFINED ? ",$" : ",." + mPredefinedType.ToString() + ".")); }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			if (release != ReleaseVersion.IFC2x3)
			{
				string s = ParserSTEP.StripField(str, ref pos, len);
				if (s[0] == '.')
					Enum.TryParse<IfcConstructionEquipmentResourceTypeEnum>(s.Replace(".", ""), true, out mPredefinedType);
			}
		}
	}
	public partial class IfcConstructionEquipmentResourceType
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + ",." + mPredefinedType.ToString() + "."; }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			string s = ParserSTEP.StripField(str, ref pos, len);
			if (s[0] == '.')
				Enum.TryParse<IfcConstructionEquipmentResourceTypeEnum>(s.Replace(".", ""), true, out mPredefinedType);
		}
	}
	public partial class IfcConstructionMaterialResource
	{
		protected override string BuildStringSTEP(ReleaseVersion release)
		{
			if (release < ReleaseVersion.IFC4)
				return base.BuildStringSTEP(release) + (mSuppliers.Count == 0 ? ",$" : ",(#" + string.Join(",#", mSuppliers.ConvertAll(x => x.Index)) + "),") +
					(mUsageRatio == null ? ",$" : "," + mUsageRatio.ToString());
			return base.BuildStringSTEP(release) + (mPredefinedType == IfcConstructionMaterialResourceTypeEnum.NOTDEFINED ? ",$" : ",." + mPredefinedType.ToString() + ".");
		}
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			if (release < ReleaseVersion.IFC4)
			{
				mSuppliers.AddRange(ParserSTEP.StripListLink(str, ref pos, len).ConvertAll(x => dictionary[x] as IfcActorSelect));
				UsageRatio = ParserIfc.parseMeasureValue(ParserSTEP.StripField(str, ref pos, len)) as IfcRatioMeasure;
			}
			else
			{
				string s = ParserSTEP.StripField(str, ref pos, len);
				if (s[0] == '.')
					Enum.TryParse<IfcConstructionMaterialResourceTypeEnum>(s.Replace(".", ""), true, out mPredefinedType);
			}
		}
	}
	public partial class IfcConstructionMaterialResourceType
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + ",." + mPredefinedType.ToString() + "."; }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			string s = ParserSTEP.StripField(str, ref pos, len);
			if (s[0] == '.')
				Enum.TryParse<IfcConstructionMaterialResourceTypeEnum>(s.Replace(".", ""), true, out mPredefinedType);
		}
	}
	public partial class IfcConstructionProductResource
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + ",." + mPredefinedType.ToString() + "."; }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			if (release != ReleaseVersion.IFC2x3)
			{
				string s = ParserSTEP.StripField(str, ref pos, len);
				if (s[0] == '.')
					Enum.TryParse<IfcConstructionProductResourceTypeEnum>(s.Replace(".", ""), true, out mPredefinedType);
			}
		}
	}
	public partial class IfcConstructionProductResourceType
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + ",." + mPredefinedType.ToString() + "."; }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			string s = ParserSTEP.StripField(str, ref pos, len);
			if (s[0] == '.')
				Enum.TryParse<IfcConstructionProductResourceTypeEnum>(s.Replace(".", ""), true, out mPredefinedType);
		}
	}
	public abstract partial class IfcConstructionResource
	{
		protected override string BuildStringSTEP(ReleaseVersion release)
		{
			if (release < ReleaseVersion.IFC4)
				return base.BuildStringSTEP(release) + (string.IsNullOrEmpty(mIdentification) ? ",$," : ",'" + ParserIfc.Encode(mIdentification) + "',") +
					(string.IsNullOrEmpty(mResourceGroup) ? "$," : "'" + ParserIfc.Encode(mResourceGroup) + "',") + ParserSTEP.ObjToLinkString(mBaseQuantitySS);
			return base.BuildStringSTEP(release) + (mUsage == 0 ? ",$," : ",#" + mUsage + ",") + ParserSTEP.ListLinksToString(mBaseCosts) + "," + ParserSTEP.ObjToLinkString(mBaseQuantity);
		}
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);

			if (release < ReleaseVersion.IFC4)
			{
				mIdentification = ParserIfc.Decode(ParserSTEP.StripString(str, ref pos, len));
				mResourceGroup = ParserIfc.Decode(ParserSTEP.StripString(str, ref pos, len));
				mBaseQuantitySS = dictionary[ParserSTEP.StripLink(str, ref pos, len)] as IfcMeasureWithUnit;
			}
			else
			{
				mUsage = ParserSTEP.StripLink(str, ref pos, len);
				mBaseCosts = ParserSTEP.StripListLink(str, ref pos, len);
				mBaseQuantity = dictionary[ParserSTEP.StripLink(str, ref pos, len)] as IfcPhysicalQuantity;
			}
		}
	}
	public abstract partial class IfcConstructionResourceType
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return (release < ReleaseVersion.IFC4 ? "" : base.BuildStringSTEP(release) + "," + ParserSTEP.ListLinksToString(mBaseCosts) + (mBaseQuantity == 0 ? ",$" : ",#" + mBaseQuantity)); }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			mBaseCosts = ParserSTEP.StripListLink(str, ref pos, len);
			mBaseQuantity = ParserSTEP.StripLink(str, ref pos, len);
		}
	}
	public abstract partial class IfcContext
	{
		protected override string BuildStringSTEP(ReleaseVersion release)
		{
			return base.BuildStringSTEP(release) + (mObjectType == "$" ? ",$" : ",'" + mObjectType + "'") + (mLongName == "$" ? ",$" : ",'" + mLongName + "'") + (mPhase == "$" ? ",$" : ",'" + mPhase + "'") +
				(mRepresentationContexts.Count == 0 ? ",$," : ",(#" + string.Join(",#", mRepresentationContexts.ConvertAll(x => x.Index)) + "),") + (mUnitsInContext == 0 ? "$" : ParserSTEP.LinkToString(mUnitsInContext));

		}
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			mObjectType = ParserSTEP.StripString(str, ref pos, len);
			mLongName = ParserSTEP.StripString(str, ref pos, len);
			mPhase = ParserSTEP.StripString(str, ref pos, len);
			RepresentationContexts.AddRange(ParserSTEP.StripListLink(str, ref pos, len).ConvertAll(x => dictionary[x] as IfcRepresentationContext));
			mUnitsInContext = ParserSTEP.StripLink(str, ref pos, len);

			if (mDatabase.mContext == null || !(this is IfcProjectLibrary))
				mDatabase.mContext = this;
		}
	}
	public partial class IfcContextDependentUnit
	{
		protected override string BuildStringSTEP(ReleaseVersion release)
		{
			return base.BuildStringSTEP(release) + ",'" + ParserIfc.Encode(mName) + "'";
		}
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			Name = ParserIfc.Decode(ParserSTEP.StripString(str, ref pos, len));
		}
	}
	public abstract partial class IfcControl
	{ 
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + (release < ReleaseVersion.IFC4 ? "" : (mIdentification == "$" ? ",$" : ",'" + mIdentification + "'")); }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			if (release != ReleaseVersion.IFC2x3)
				mIdentification = ParserSTEP.StripString(str, ref pos, len);
		}
	}
	public partial class IfcController  
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + (release < ReleaseVersion.IFC4 ? "" : (mPredefinedType == IfcControllerTypeEnum.NOTDEFINED ? ",$" : ",." + mPredefinedType.ToString() + ".")); }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			string s = ParserSTEP.StripField(str, ref pos, len);
			if (s.StartsWith("."))
				Enum.TryParse<IfcControllerTypeEnum>(s.Replace(".", ""), true, out mPredefinedType);
		}
	}
	public partial class IfcControllerType
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + ",." + mPredefinedType.ToString() + "."; }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			string s = ParserSTEP.StripField(str, ref pos, len);
			if (s.StartsWith("."))
				Enum.TryParse<IfcControllerTypeEnum>(s.Replace(".", ""), true, out mPredefinedType);
		}
	}
	public partial class IfcConversionBasedUnit
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + ",'" + mName + "'," + ParserSTEP.LinkToString(mConversionFactor); }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			mName = ParserSTEP.StripString(str, ref pos, len);
			mConversionFactor = ParserSTEP.StripLink(str, ref pos, len);
		}
	}
	public partial class IfcConversionBasedUnitWithOffset
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + "," + ParserSTEP.DoubleToString(mConversionOffset); }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			mConversionOffset = ParserSTEP.StripDouble(str, ref pos, len);
		}
	}
	public partial class IfcConveyorSegment
	{
		protected override string BuildStringSTEP(ReleaseVersion release)
		{
			return base.BuildStringSTEP(release) + (mPredefinedType == IfcConveyorSegmentTypeEnum.NOTDEFINED ? ",$" : ",." + mPredefinedType.ToString() + ".");
		}
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			string s = ParserSTEP.StripField(str, ref pos, len);
			if (s.StartsWith("."))
				Enum.TryParse<IfcConveyorSegmentTypeEnum>(s.Replace(".", ""), true, out mPredefinedType);
		}
	}
	public partial class IfcConveyorSegmentType
	{
		protected override string BuildStringSTEP(ReleaseVersion release)
		{
			return base.BuildStringSTEP(release) + ",." + mPredefinedType.ToString() + ".";
		}
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			string s = ParserSTEP.StripField(str, ref pos, len);
			if (s.StartsWith("."))
				Enum.TryParse<IfcConveyorSegmentTypeEnum>(s.Replace(".", ""), true, out mPredefinedType);
		}
	}
	public partial class IfcCooledBeam
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + (release < ReleaseVersion.IFC4 ? "" : (mPredefinedType == IfcCooledBeamTypeEnum.NOTDEFINED ? ",$" : ",." + mPredefinedType.ToString() + ".")); }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			string s = ParserSTEP.StripField(str, ref pos, len);
			if (s.StartsWith("."))
				Enum.TryParse<IfcCooledBeamTypeEnum>(s.Replace(".", ""), true, out mPredefinedType);
		}
	}
	public partial class IfcCooledBeamType
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + ",." + mPredefinedType.ToString() + "."; }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			string s = ParserSTEP.StripField(str, ref pos, len);
			if (s.StartsWith("."))
				Enum.TryParse<IfcCooledBeamTypeEnum>(s.Replace(".", ""), true, out mPredefinedType);
		}
	}
	public partial class IfcCoolingTower
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + (release < ReleaseVersion.IFC4 ? "" : (mPredefinedType == IfcCoolingTowerTypeEnum.NOTDEFINED ? ",$" : ",." + mPredefinedType.ToString() + ".")); }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			string s = ParserSTEP.StripField(str, ref pos, len);
			if (s.StartsWith("."))
				Enum.TryParse<IfcCoolingTowerTypeEnum>(s.Replace(".", ""), true, out mPredefinedType);
		}
	}
	public partial class IfcCoolingTowerType
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + ",." + mPredefinedType.ToString() + "."; }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			string s = ParserSTEP.StripField(str, ref pos, len);
			if (s.StartsWith("."))
				Enum.TryParse<IfcCoolingTowerTypeEnum>(s.Replace(".", ""), true, out mPredefinedType);
		}
	}
	public partial class IfcCoordinatedUniversalTimeOffset
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return mHourOffset + "," + mMinuteOffset + ",." + mSense.ToString() + "."; }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			mHourOffset = ParserSTEP.StripInt(str, ref pos, len);
			mMinuteOffset = ParserSTEP.StripInt(str, ref pos, len);
			Enum.TryParse<IfcAheadOrBehind>(ParserSTEP.StripField(str, ref pos, len).Replace(".", ""), true, out mSense);
		}
	}
	public abstract partial class IfcCoordinateOperation
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return "#" + mSourceCRS.StepId + ",#" + mTargetCRS.StepId; }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			SourceCRS = dictionary[ParserSTEP.StripLink(str, ref pos, len)] as IfcCoordinateReferenceSystemSelect;
			TargetCRS = dictionary[ParserSTEP.StripLink(str, ref pos, len)] as IfcCoordinateReferenceSystem;
		}
	}
	public abstract partial class IfcCoordinateReferenceSystem
	{
		protected override string BuildStringSTEP(ReleaseVersion release)
		{
			return "'" + ParserIfc.Encode(mName) + "'," + (string.IsNullOrEmpty(mDescription) ? "$," : "'" + ParserIfc.Encode(mDescription) + "',") +
				(string.IsNullOrEmpty(mGeodeticDatum) ? "$" : "'" + ParserIfc.Encode(mGeodeticDatum) + "'") + (string.IsNullOrEmpty(mVerticalDatum) ? ",$" : ",'" + ParserIfc.Encode(mVerticalDatum) + "'");
		}
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			mName = ParserIfc.Decode(ParserSTEP.StripString(str, ref pos, len));
			mDescription = ParserIfc.Decode(ParserSTEP.StripString(str, ref pos, len));
			mGeodeticDatum = ParserIfc.Decode(ParserSTEP.StripString(str, ref pos, len));
			mVerticalDatum = ParserIfc.Decode(ParserSTEP.StripString(str, ref pos, len));
		}
	}
	public partial class IfcCosineSpiral
	{
		protected override string BuildStringSTEP(ReleaseVersion release)
		{
			return base.BuildStringSTEP(release) + ParserSTEP.DoubleToString(mCosineTerm) + "," + ParserSTEP.DoubleOptionalToString(mConstantTerm);
		}
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			CosineTerm = ParserSTEP.StripDouble(str, ref pos, len);
			ConstantTerm = ParserSTEP.StripDouble(str, ref pos, len);
		}
	}
	public partial class IfcCostItem
	{
		protected override string BuildStringSTEP(ReleaseVersion release)
		{
			string s = base.BuildStringSTEP(release);
			if (release != ReleaseVersion.IFC2x3)
			{
				s += ",." + mPredefinedType.ToString();
				if (mCostValues.Count == 0)
					s += ".,$,";
				else
				{
					s += ".,(" + ParserSTEP.LinkToString(mCostValues[0]);
					for (int icounter = 1; icounter < mCostValues.Count; icounter++)
						s += "," + ParserSTEP.LinkToString(mCostValues[icounter]);
					s += "),";
				}
				if (mCostQuantities.Count == 0)
					s += "$";
				else
				{
					s += "(" + ParserSTEP.LinkToString(mCostQuantities[0]);
					for (int icounter = 1; icounter < mCostQuantities.Count; icounter++)
						s += "," + ParserSTEP.LinkToString(mCostQuantities[icounter]);
					s += ")";
				}
			}
			return s;
		}
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			if (release != ReleaseVersion.IFC2x3)
			{
				string s = ParserSTEP.StripField(str, ref pos, len);
				if (s.StartsWith("."))
					Enum.TryParse<IfcCostItemTypeEnum>(s.Replace(".", ""), true, out mPredefinedType);
				mCostValues = ParserSTEP.StripListLink(str, ref pos, len);
				mCostQuantities = ParserSTEP.StripListLink(str, ref pos, len);
			}
		}
	}
	public partial class IfcCostSchedule
	{
		protected override string BuildStringSTEP(ReleaseVersion release)
		{
			if (release < ReleaseVersion.IFC4)
			{
				string str = base.BuildStringSTEP(release) + "," + ParserSTEP.LinkToString(mSubmittedBy) + "," + ParserSTEP.LinkToString(mPreparedBy) + "," + ParserSTEP.LinkToString(mSubmittedOnSS) + "," + mStatus;
				if (mTargetUsers.Count > 0)
				{
					str += ",(" + ParserSTEP.LinkToString(mTargetUsers[0]);
					for (int icounter = 1; icounter < mTargetUsers.Count; icounter++)
						str += "," + ParserSTEP.LinkToString(mTargetUsers[icounter]);
					str += "),";
				}
				else
					str += ",$,";
				return str + ParserSTEP.LinkToString(mUpdateDateSS) + (mIdentification == "$" ? ",$,." : ",'" + mIdentification + "',.") + mPredefinedType.ToString() + ".";
			}
			return base.BuildStringSTEP(release) + ",." + mPredefinedType.ToString() + (mStatus == "$" ? ".,$," : ".,'" + mStatus + "',") + mSubmittedOn + "," + mUpdateDate;
		}
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			if (release < ReleaseVersion.IFC4)
			{
				mSubmittedBy = ParserSTEP.StripLink(str, ref pos, len);
				mPreparedBy = ParserSTEP.StripLink(str, ref pos, len);
				mSubmittedOnSS = ParserSTEP.StripLink(str, ref pos, len);
				mStatus = ParserSTEP.StripString(str, ref pos, len);
				mTargetUsers = ParserSTEP.StripListLink(str, ref pos, len);
				mUpdateDateSS = ParserSTEP.StripLink(str, ref pos, len);
				mIdentification = ParserSTEP.StripString(str, ref pos, len);
				Enum.TryParse<IfcCostScheduleTypeEnum>(ParserSTEP.StripField(str, ref pos, len).Replace(".", ""), true, out mPredefinedType);
			}
			else
			{
				Enum.TryParse<IfcCostScheduleTypeEnum>(ParserSTEP.StripField(str, ref pos, len).Replace(".", ""), true, out mPredefinedType);
				mStatus = ParserSTEP.StripString(str, ref pos, len);
				mSubmittedOn = IfcDateTime.ParseSTEP(ParserSTEP.StripField(str, ref pos, len));
				mUpdateDate = IfcDateTime.ParseSTEP(ParserSTEP.StripField(str, ref pos, len));
			}
		}
	}
	public partial class IfcCostValue
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + (release < ReleaseVersion.IFC4 ? (mCategory == "$" ? ",$," : ",'" + mCategory + "',") + (mCondition == "$" ? "$" : "'" + mCondition + "'") : ""); }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			if (release < ReleaseVersion.IFC4)
			{
				mCategory = ParserSTEP.StripString(str, ref pos, len);
				mCondition = ParserSTEP.StripString(str, ref pos, len);
			}
		}
	}
	public partial class IfcCourse
	{
		protected override string BuildStringSTEP(ReleaseVersion release)
		{
			return base.BuildStringSTEP(release) + (mPredefinedType == IfcCourseTypeEnum.NOTDEFINED ? ",$" : ",." + mPredefinedType.ToString() + ".");
		}
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			string s = ParserSTEP.StripField(str, ref pos, len);
			if (s.StartsWith("."))
				Enum.TryParse<IfcCourseTypeEnum>(s.Replace(".", ""), true, out mPredefinedType);
		}
	}
	public partial class IfcCourseType
	{
		protected override string BuildStringSTEP(ReleaseVersion release)
		{
			return base.BuildStringSTEP(release) + ",." + mPredefinedType.ToString() + ".";
		}
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			string s = ParserSTEP.StripField(str, ref pos, len);
			if (s.StartsWith("."))
				Enum.TryParse<IfcCourseTypeEnum>(s.Replace(".", ""), true, out mPredefinedType);
		}
	}
	public partial class IfcCovering
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + "," + (mPredefinedType == IfcCoveringTypeEnum.NOTDEFINED ? "$" : "." + mPredefinedType.ToString() + "."); }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			if (release != ReleaseVersion.IFC2x3)
			{
				string s = ParserSTEP.StripField(str, ref pos, len);
				if (s.StartsWith("."))
					Enum.TryParse<IfcCoveringTypeEnum>(s.Replace(".", ""), true, out mPredefinedType);
			}
		}
	}
	public partial class IfcCoveringType	
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + ",." + mPredefinedType.ToString() + "."; }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			string s = ParserSTEP.StripField(str, ref pos, len);
			if (s.StartsWith("."))
				Enum.TryParse<IfcCoveringTypeEnum>(s.Replace(".", ""), true, out mPredefinedType);
		}
	}
	public partial class IfcCraneRailAShapeProfileDef
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + "," + ParserSTEP.DoubleToString(mOverallHeight) + "," + ParserSTEP.DoubleToString(mBaseWidth2) + "," + ParserSTEP.DoubleOptionalToString(mRadius) + "," + ParserSTEP.DoubleToString(mHeadWidth) + "," + ParserSTEP.DoubleToString(mHeadDepth2) + "," + ParserSTEP.DoubleToString(mHeadDepth3) + "," + ParserSTEP.DoubleToString(mWebThickness) + "," + ParserSTEP.DoubleToString(mBaseDepth1) + "," + ParserSTEP.DoubleToString(mBaseDepth2) + "," + ParserSTEP.DoubleToString(mBaseDepth3) + "," + ParserSTEP.DoubleOptionalToString(mCentreOfGravityInY); }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			mOverallHeight = ParserSTEP.StripDouble(str, ref pos, len);
			mBaseWidth2 = ParserSTEP.StripDouble(str, ref pos, len);
			mRadius = ParserSTEP.StripDouble(str, ref pos, len);
			mHeadWidth = ParserSTEP.StripDouble(str, ref pos, len);
			mHeadDepth2 = ParserSTEP.StripDouble(str, ref pos, len);
			mHeadDepth3 = ParserSTEP.StripDouble(str, ref pos, len);
			mWebThickness = ParserSTEP.StripDouble(str, ref pos, len);
			mBaseWidth4 = ParserSTEP.StripDouble(str, ref pos, len);
			mBaseDepth1 = ParserSTEP.StripDouble(str, ref pos, len);
			mBaseDepth2 = ParserSTEP.StripDouble(str, ref pos, len);
			mBaseDepth3 = ParserSTEP.StripDouble(str, ref pos, len);
			mCentreOfGravityInY = ParserSTEP.StripDouble(str, ref pos, len);
		}
	}
	public partial class IfcCraneRailFShapeProfileDef
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + "," + ParserSTEP.DoubleToString(mOverallHeight) + "," + ParserSTEP.DoubleToString(mHeadWidth) + "," + ParserSTEP.DoubleOptionalToString(mRadius) + "," + ParserSTEP.DoubleToString(mHeadDepth2) + "," + ParserSTEP.DoubleToString(mHeadDepth3) + "," + ParserSTEP.DoubleToString(mWebThickness) + "," + ParserSTEP.DoubleToString(mBaseDepth1) + "," + ParserSTEP.DoubleToString(mBaseDepth2) + "," + ParserSTEP.DoubleOptionalToString(mCentreOfGravityInY); }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			mOverallHeight = ParserSTEP.StripDouble(str, ref pos, len);
			mHeadWidth = ParserSTEP.StripDouble(str, ref pos, len);
			mRadius = ParserSTEP.StripDouble(str, ref pos, len);
			mHeadDepth2 = ParserSTEP.StripDouble(str, ref pos, len);
			mHeadDepth3 = ParserSTEP.StripDouble(str, ref pos, len);
			mWebThickness = ParserSTEP.StripDouble(str, ref pos, len);
			mBaseDepth1 = ParserSTEP.StripDouble(str, ref pos, len);
			mBaseDepth2 = ParserSTEP.StripDouble(str, ref pos, len);
			mCentreOfGravityInY = ParserSTEP.StripDouble(str, ref pos, len);
		}
	}
	public partial class IfcCrewResource
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + ",." + mPredefinedType.ToString() + "."; }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			if (release != ReleaseVersion.IFC2x3)
			{
				string s = ParserSTEP.StripField(str, ref pos, len);
				if (s.StartsWith("."))
					Enum.TryParse<IfcCrewResourceTypeEnum>(s.Replace(".", ""), true, out mPredefinedType);
			}
		}
	}
	public partial class IfcCrewResourceType
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + ",." + mPredefinedType.ToString() + "."; }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			string s = ParserSTEP.StripField(str, ref pos, len);
			if (s.StartsWith("."))
				Enum.TryParse<IfcCrewResourceTypeEnum>(s.Replace(".", ""), true, out mPredefinedType);
		}
	}
	public abstract partial class IfcCsgPrimitive3D
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return ParserSTEP.LinkToString(mPosition); }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary) { mPosition = ParserSTEP.StripLink(str, ref pos, len); }
	}
	public partial class IfcCsgSolid
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return ParserSTEP.LinkToString(mTreeRootExpression); }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary) { mTreeRootExpression = ParserSTEP.StripLink(str, ref pos, len); }
	}
	public partial class IfcCShapeProfileDef
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + "," + ParserSTEP.DoubleToString(mDepth) + "," + ParserSTEP.DoubleToString(mWidth) + "," + ParserSTEP.DoubleToString(mWallThickness) + "," + ParserSTEP.DoubleToString(mGirth) + "," + ParserSTEP.DoubleOptionalToString(mInternalFilletRadius) + (release < ReleaseVersion.IFC4 ? "," + ParserSTEP.DoubleOptionalToString(mCentreOfGravityInX) : ""); }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			mDepth = ParserSTEP.StripDouble(str, ref pos, len);
			mWidth = ParserSTEP.StripDouble(str, ref pos, len);
			mWallThickness = ParserSTEP.StripDouble(str, ref pos, len);
			mGirth = ParserSTEP.StripDouble(str, ref pos, len);
			mInternalFilletRadius = ParserSTEP.StripDouble(str, ref pos, len);
			if (release < ReleaseVersion.IFC4)
				mCentreOfGravityInX = ParserSTEP.StripDouble(str, ref pos, len);
		}
	}
	public partial class IfcCurrencyRelationship
	{
		protected override string BuildStringSTEP(ReleaseVersion release)
		{
			return base.BuildStringSTEP(release) +
			",#" + mRelatingMonetaryUnit.StepId +
			",#" + mRelatedMonetaryUnit.StepId + "," +
			ParserSTEP.DoubleOptionalToString(mExchangeRate) + "," +
			IfcDateTime.STEPAttribute(mRateDateTime) +
			(mRateSource == null ? ",$" : ",#" + mRateSource.StepId);
		}
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			RelatingMonetaryUnit = dictionary[ParserSTEP.StripLink(str, ref pos, len)] as IfcMonetaryUnit;
			RelatedMonetaryUnit = dictionary[ParserSTEP.StripLink(str, ref pos, len)] as IfcMonetaryUnit;
			ExchangeRate = ParserSTEP.StripDouble(str, ref pos, len);
			RateDateTime = IfcDateTime.ParseSTEP(ParserSTEP.StripField(str, ref pos, len));
			RateSource = dictionary[ParserSTEP.StripLink(str, ref pos, len)] as IfcLibraryInformation;
		}
	}
	public partial class IfcCurtainWall
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return (release < ReleaseVersion.IFC4 ? base.BuildStringSTEP(release) : base.BuildStringSTEP(release) + ",." + mPredefinedType.ToString() + "."); }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			if (release != ReleaseVersion.IFC2x3)
			{
				string s = ParserSTEP.StripField(str, ref pos, len);
				if (s.StartsWith("."))
					Enum.TryParse<IfcCurtainWallTypeEnum>(s.Replace(".", ""), true, out mPredefinedType);
			}
		}
	}
	public partial class IfcCurtainWallType
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + ",." + mPredefinedType.ToString() + "."; }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			string s = ParserSTEP.StripField(str, ref pos, len);
			if (s.StartsWith("."))
				Enum.TryParse<IfcCurtainWallTypeEnum>(s.Replace(".", ""), true, out mPredefinedType);
		}
	}
	public partial class IfcCurveBoundedPlane
	{
		protected override string BuildStringSTEP(ReleaseVersion release)
		{
			return "#" + mBasisSurface.StepId + ",#" + mOuterBoundary.StepId + 
				(mInnerBoundaries.Count > 0 || release < ReleaseVersion.IFC4 ? ",(" + string.Join(",", mInnerBoundaries.Select(x=> "#" + x.StepId)) + ")" : ",$");
		}
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			BasisSurface = dictionary[ParserSTEP.StripLink(str, ref pos, len)] as IfcPlane;
			OuterBoundary = dictionary[ParserSTEP.StripLink(str, ref pos, len)] as IfcCurve;
			InnerBoundaries.AddRange(ParserSTEP.StripListLink(str, ref pos, len).Select(x=>dictionary[x] as IfcCurve));
		}
	}
	public partial class IfcCurveBoundedSurface
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return "#" + mBasisSurface.StepId + ",(" + string.Join(",", mBoundaries.Select(x=>"#" + x.StepId)) + (mImplicitOuter ? "),.T." : "),.F."); }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			mBasisSurface = dictionary[ParserSTEP.StripLink(str, ref pos, len)] as IfcSurface;
			Boundaries.AddRange(ParserSTEP.StripListLink(str, ref pos, len).Select(x => dictionary[x] as IfcBoundaryCurve));
			mImplicitOuter = ParserSTEP.StripBool(str, ref pos, len);
		}
	}
	public partial class IfcCurveSegment
	{
		protected override string BuildStringSTEP(ReleaseVersion release)
		{
			return base.BuildStringSTEP(release) + ",#" + mPlacement.StepId + "," + mSegmentStart.ToString() + "," +
				mSegmentLength.ToString() + ",#" + mParentCurve.StepId;
		}
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			Placement = dictionary[ParserSTEP.StripLink(str, ref pos, len)] as IfcPlacement;
			SegmentStart = ParserIfc.parseMeasureValue(ParserSTEP.StripField(str, ref pos, len)) as IfcCurveMeasureSelect;
			SegmentLength = ParserIfc.parseMeasureValue(ParserSTEP.StripField(str, ref pos, len)) as IfcCurveMeasureSelect;
			ParentCurve = dictionary[ParserSTEP.StripLink(str, ref pos, len)] as IfcCurve;
		}
	}
	public abstract partial class IfcCurveSegment2D
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return "#" + mStartPoint.mIndex + 
				"," + ParserSTEP.DoubleToString(mStartDirection) + "," + formatLength(mSegmentLength); }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int, BaseClassIfc> dictionary)
		{
			mStartPoint = dictionary[ParserSTEP.StripLink(str, ref pos, len)] as IfcCartesianPoint;
			mStartDirection = ParserSTEP.StripDouble(str, ref pos, len);
			mSegmentLength = ParserSTEP.StripDouble(str, ref pos, len);
		}
	}
	public partial class IfcCurveStyle
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return base.BuildStringSTEP(release) + "," + ParserSTEP.LinkToString(mCurveFont) + (mCurveWidth == null ? ",$," : "," + mCurveWidth.ToString() + ",") + ParserSTEP.LinkToString(mCurveColour) + (release != ReleaseVersion.IFC2x3 ? (mModelOrDraughting == IfcLogicalEnum.UNKNOWN ? ",$" : ","+ ParserIfc.LogicalToString(mModelOrDraughting)) :"") ; }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int,BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			mCurveFont = ParserSTEP.StripLink(str, ref pos, len);
			string s = ParserSTEP.StripField(str, ref pos, len);
			if(str != "$")
				mCurveWidth = ParserIfc.parseValue(str) as IfcSizeSelect;
			mCurveColour = ParserSTEP.StripLink(str, ref pos, len);
			if (release != ReleaseVersion.IFC2x3)
				mModelOrDraughting = ParserIfc.StripLogical(str, ref pos, len);
		}
	}
	public partial class IfcCurveStyleFont
	{
		protected override string BuildStringSTEP(ReleaseVersion release)
		{
			return (mName == "$" ? "$,(" : "'" + mName + "',(") +
				string.Join(",", mPatternList.Select(x => "#" + x.StepId)) + ")";
		}
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int,BaseClassIfc> dictionary)
		{
			mName = ParserSTEP.StripString(str, ref pos, len);
			mPatternList.AddRange(ParserSTEP.StripListLink(str, ref pos, len).Select(x => dictionary[x] as IfcCurveStyleFontPattern));
		}
	}
	public partial class IfcCurveStyleFontAndScaling
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return ",'" + mName + "'," + ParserSTEP.LinkToString(mCurveFont) + "," + mCurveFontScaling.ToString(); }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int,BaseClassIfc> dictionary)
		{
			mName = ParserSTEP.StripString(str, ref pos, len);
			mCurveFont = ParserSTEP.StripLink(str, ref pos, len);
			mCurveFontScaling = new IfcPositiveRatioMeasure(ParserSTEP.StripField(str, ref pos, len));
		}
	}
	public partial class IfcCurveStyleFontPattern
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return ParserSTEP.DoubleToString(mVisibleSegmentLength) + "," + ParserSTEP.DoubleToString(mInvisibleSegmentLength); }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int,BaseClassIfc> dictionary)
		{
			mVisibleSegmentLength = ParserSTEP.StripDouble(str, ref pos, len);
			mInvisibleSegmentLength = ParserSTEP.StripDouble(str, ref pos, len);
		}
	}
	public partial class IfcCylindricalSurface
	{
		protected override string BuildStringSTEP(ReleaseVersion release) { return  base.BuildStringSTEP(release) + "," + ParserSTEP.DoubleToString(mRadius); }
		internal override void parse(string str, ref int pos, ReleaseVersion release, int len, ConcurrentDictionary<int,BaseClassIfc> dictionary)
		{
			base.parse(str, ref pos, release, len, dictionary);
			mRadius = ParserSTEP.StripDouble(str, ref pos, len);
		}
	}
}
