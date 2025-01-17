﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Purchesed
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="GermentsDB")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTbTrime(TbTrime instance);
    partial void UpdateTbTrime(TbTrime instance);
    partial void DeleteTbTrime(TbTrime instance);
    partial void InsertTb_TrimeLab(Tb_TrimeLab instance);
    partial void UpdateTb_TrimeLab(Tb_TrimeLab instance);
    partial void DeleteTb_TrimeLab(Tb_TrimeLab instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::Purchesed.Properties.Settings.Default.GermentsDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<TbTrime> TbTrimes
		{
			get
			{
				return this.GetTable<TbTrime>();
			}
		}
		
		public System.Data.Linq.Table<Tb_TrimeLab> Tb_TrimeLabs
		{
			get
			{
				return this.GetTable<Tb_TrimeLab>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TbTrime")]
	public partial class TbTrime : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _TpId;
		
		private System.DateTime _Date;
		
		private string _TrimeClass;
		
		private string _Description;
		
		private string _Spece;
		
		private string _Dyeing;
		
		private string _Finishing;
		
		private System.Data.Linq.Binary _Picture;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnTpIdChanging(string value);
    partial void OnTpIdChanged();
    partial void OnDateChanging(System.DateTime value);
    partial void OnDateChanged();
    partial void OnTrimeClassChanging(string value);
    partial void OnTrimeClassChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnSpeceChanging(string value);
    partial void OnSpeceChanged();
    partial void OnDyeingChanging(string value);
    partial void OnDyeingChanged();
    partial void OnFinishingChanging(string value);
    partial void OnFinishingChanged();
    partial void OnPictureChanging(System.Data.Linq.Binary value);
    partial void OnPictureChanged();
    #endregion
		
		public TbTrime()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TpId", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string TpId
		{
			get
			{
				return this._TpId;
			}
			set
			{
				if ((this._TpId != value))
				{
					this.OnTpIdChanging(value);
					this.SendPropertyChanging();
					this._TpId = value;
					this.SendPropertyChanged("TpId");
					this.OnTpIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="Date NOT NULL")]
		public System.DateTime Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TrimeClass", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string TrimeClass
		{
			get
			{
				return this._TrimeClass;
			}
			set
			{
				if ((this._TrimeClass != value))
				{
					this.OnTrimeClassChanging(value);
					this.SendPropertyChanging();
					this._TrimeClass = value;
					this.SendPropertyChanged("TrimeClass");
					this.OnTrimeClassChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Spece", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Spece
		{
			get
			{
				return this._Spece;
			}
			set
			{
				if ((this._Spece != value))
				{
					this.OnSpeceChanging(value);
					this.SendPropertyChanging();
					this._Spece = value;
					this.SendPropertyChanged("Spece");
					this.OnSpeceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dyeing", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Dyeing
		{
			get
			{
				return this._Dyeing;
			}
			set
			{
				if ((this._Dyeing != value))
				{
					this.OnDyeingChanging(value);
					this.SendPropertyChanging();
					this._Dyeing = value;
					this.SendPropertyChanged("Dyeing");
					this.OnDyeingChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Finishing", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Finishing
		{
			get
			{
				return this._Finishing;
			}
			set
			{
				if ((this._Finishing != value))
				{
					this.OnFinishingChanging(value);
					this.SendPropertyChanging();
					this._Finishing = value;
					this.SendPropertyChanged("Finishing");
					this.OnFinishingChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Picture", DbType="Image NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Picture
		{
			get
			{
				return this._Picture;
			}
			set
			{
				if ((this._Picture != value))
				{
					this.OnPictureChanging(value);
					this.SendPropertyChanging();
					this._Picture = value;
					this.SendPropertyChanged("Picture");
					this.OnPictureChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tb_TrimeLab")]
	public partial class Tb_TrimeLab : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _TrimeId;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnTrimeIdChanging(string value);
    partial void OnTrimeIdChanged();
    #endregion
		
		public Tb_TrimeLab()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TrimeId", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string TrimeId
		{
			get
			{
				return this._TrimeId;
			}
			set
			{
				if ((this._TrimeId != value))
				{
					this.OnTrimeIdChanging(value);
					this.SendPropertyChanging();
					this._TrimeId = value;
					this.SendPropertyChanged("TrimeId");
					this.OnTrimeIdChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
