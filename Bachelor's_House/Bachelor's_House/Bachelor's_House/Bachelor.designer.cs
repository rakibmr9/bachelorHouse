﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bachelor_s_House
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Bachelor")]
	public partial class BachelorDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertMember(Member instance);
    partial void UpdateMember(Member instance);
    partial void DeleteMember(Member instance);
    partial void InsertAccount(Account instance);
    partial void UpdateAccount(Account instance);
    partial void DeleteAccount(Account instance);
    partial void InsertBalance(Balance instance);
    partial void UpdateBalance(Balance instance);
    partial void DeleteBalance(Balance instance);
    partial void InsertMealList(MealList instance);
    partial void UpdateMealList(MealList instance);
    partial void DeleteMealList(MealList instance);
    partial void InsertTotalCal(TotalCal instance);
    partial void UpdateTotalCal(TotalCal instance);
    partial void DeleteTotalCal(TotalCal instance);
    #endregion
		
		public BachelorDataContext() : 
				base(global::Bachelor_s_House.Properties.Settings.Default.BachelorConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public BachelorDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BachelorDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BachelorDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BachelorDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Member> Members
		{
			get
			{
				return this.GetTable<Member>();
			}
		}
		
		public System.Data.Linq.Table<Account> Accounts
		{
			get
			{
				return this.GetTable<Account>();
			}
		}
		
		public System.Data.Linq.Table<Balance> Balances
		{
			get
			{
				return this.GetTable<Balance>();
			}
		}
		
		public System.Data.Linq.Table<MealList> MealLists
		{
			get
			{
				return this.GetTable<MealList>();
			}
		}
		
		public System.Data.Linq.Table<TotalCal> TotalCals
		{
			get
			{
				return this.GetTable<TotalCal>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Member")]
	public partial class Member : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private string _organization;
		
		private string _personal_phone;
		
		private string _email;
		
		private string _address;
		
		private string _father_name;
		
		private string _father_phone;
		
		private System.DateTime _joinning_date;
		
		private string _password;
		
		private int _type;
		
		private EntityRef<Account> _Account;
		
		private EntityRef<MealList> _MealList;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnorganizationChanging(string value);
    partial void OnorganizationChanged();
    partial void Onpersonal_phoneChanging(string value);
    partial void Onpersonal_phoneChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnaddressChanging(string value);
    partial void OnaddressChanged();
    partial void Onfather_nameChanging(string value);
    partial void Onfather_nameChanged();
    partial void Onfather_phoneChanging(string value);
    partial void Onfather_phoneChanged();
    partial void Onjoinning_dateChanging(System.DateTime value);
    partial void Onjoinning_dateChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void OntypeChanging(int value);
    partial void OntypeChanged();
    #endregion
		
		public Member()
		{
			this._Account = default(EntityRef<Account>);
			this._MealList = default(EntityRef<MealList>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_organization", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string organization
		{
			get
			{
				return this._organization;
			}
			set
			{
				if ((this._organization != value))
				{
					this.OnorganizationChanging(value);
					this.SendPropertyChanging();
					this._organization = value;
					this.SendPropertyChanged("organization");
					this.OnorganizationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_personal_phone", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string personal_phone
		{
			get
			{
				return this._personal_phone;
			}
			set
			{
				if ((this._personal_phone != value))
				{
					this.Onpersonal_phoneChanging(value);
					this.SendPropertyChanging();
					this._personal_phone = value;
					this.SendPropertyChanged("personal_phone");
					this.Onpersonal_phoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_address", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string address
		{
			get
			{
				return this._address;
			}
			set
			{
				if ((this._address != value))
				{
					this.OnaddressChanging(value);
					this.SendPropertyChanging();
					this._address = value;
					this.SendPropertyChanged("address");
					this.OnaddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_father_name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string father_name
		{
			get
			{
				return this._father_name;
			}
			set
			{
				if ((this._father_name != value))
				{
					this.Onfather_nameChanging(value);
					this.SendPropertyChanging();
					this._father_name = value;
					this.SendPropertyChanged("father_name");
					this.Onfather_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_father_phone", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string father_phone
		{
			get
			{
				return this._father_phone;
			}
			set
			{
				if ((this._father_phone != value))
				{
					this.Onfather_phoneChanging(value);
					this.SendPropertyChanging();
					this._father_phone = value;
					this.SendPropertyChanged("father_phone");
					this.Onfather_phoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_joinning_date", DbType="Date NOT NULL")]
		public System.DateTime joinning_date
		{
			get
			{
				return this._joinning_date;
			}
			set
			{
				if ((this._joinning_date != value))
				{
					this.Onjoinning_dateChanging(value);
					this.SendPropertyChanging();
					this._joinning_date = value;
					this.SendPropertyChanged("joinning_date");
					this.Onjoinning_dateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_type", DbType="Int NOT NULL")]
		public int type
		{
			get
			{
				return this._type;
			}
			set
			{
				if ((this._type != value))
				{
					this.OntypeChanging(value);
					this.SendPropertyChanging();
					this._type = value;
					this.SendPropertyChanged("type");
					this.OntypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Member_Account", Storage="_Account", ThisKey="id", OtherKey="id", IsUnique=true, IsForeignKey=false)]
		public Account Account
		{
			get
			{
				return this._Account.Entity;
			}
			set
			{
				Account previousValue = this._Account.Entity;
				if (((previousValue != value) 
							|| (this._Account.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Account.Entity = null;
						previousValue.Member = null;
					}
					this._Account.Entity = value;
					if ((value != null))
					{
						value.Member = this;
					}
					this.SendPropertyChanged("Account");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Member_MealList", Storage="_MealList", ThisKey="id", OtherKey="id", IsUnique=true, IsForeignKey=false)]
		public MealList MealList
		{
			get
			{
				return this._MealList.Entity;
			}
			set
			{
				MealList previousValue = this._MealList.Entity;
				if (((previousValue != value) 
							|| (this._MealList.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._MealList.Entity = null;
						previousValue.Member = null;
					}
					this._MealList.Entity = value;
					if ((value != null))
					{
						value.Member = this;
					}
					this.SendPropertyChanged("MealList");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Account")]
	public partial class Account : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private int _balance;
		
		private int _totalNumberOfMeal;
		
		private EntityRef<Member> _Member;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnbalanceChanging(int value);
    partial void OnbalanceChanged();
    partial void OntotalNumberOfMealChanging(int value);
    partial void OntotalNumberOfMealChanged();
    #endregion
		
		public Account()
		{
			this._Member = default(EntityRef<Member>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
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
					if (this._Member.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_balance", DbType="Int NOT NULL")]
		public int balance
		{
			get
			{
				return this._balance;
			}
			set
			{
				if ((this._balance != value))
				{
					this.OnbalanceChanging(value);
					this.SendPropertyChanging();
					this._balance = value;
					this.SendPropertyChanged("balance");
					this.OnbalanceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_totalNumberOfMeal", DbType="Int NOT NULL")]
		public int totalNumberOfMeal
		{
			get
			{
				return this._totalNumberOfMeal;
			}
			set
			{
				if ((this._totalNumberOfMeal != value))
				{
					this.OntotalNumberOfMealChanging(value);
					this.SendPropertyChanging();
					this._totalNumberOfMeal = value;
					this.SendPropertyChanged("totalNumberOfMeal");
					this.OntotalNumberOfMealChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Member_Account", Storage="_Member", ThisKey="id", OtherKey="id", IsForeignKey=true)]
		public Member Member
		{
			get
			{
				return this._Member.Entity;
			}
			set
			{
				Member previousValue = this._Member.Entity;
				if (((previousValue != value) 
							|| (this._Member.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Member.Entity = null;
						previousValue.Account = null;
					}
					this._Member.Entity = value;
					if ((value != null))
					{
						value.Account = this;
						this._id = value.id;
					}
					else
					{
						this._id = default(int);
					}
					this.SendPropertyChanged("Member");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Balance")]
	public partial class Balance : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private int _totalBalance;
		
		private int _totalCost;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OntotalBalanceChanging(int value);
    partial void OntotalBalanceChanged();
    partial void OntotalCostChanging(int value);
    partial void OntotalCostChanged();
    #endregion
		
		public Balance()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_totalBalance", DbType="Int NOT NULL")]
		public int totalBalance
		{
			get
			{
				return this._totalBalance;
			}
			set
			{
				if ((this._totalBalance != value))
				{
					this.OntotalBalanceChanging(value);
					this.SendPropertyChanging();
					this._totalBalance = value;
					this.SendPropertyChanged("totalBalance");
					this.OntotalBalanceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_totalCost", DbType="Int NOT NULL")]
		public int totalCost
		{
			get
			{
				return this._totalCost;
			}
			set
			{
				if ((this._totalCost != value))
				{
					this.OntotalCostChanging(value);
					this.SendPropertyChanging();
					this._totalCost = value;
					this.SendPropertyChanged("totalCost");
					this.OntotalCostChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MealList")]
	public partial class MealList : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private int _dailyMeal;
		
		private EntityRef<Member> _Member;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OndailyMealChanging(int value);
    partial void OndailyMealChanged();
    #endregion
		
		public MealList()
		{
			this._Member = default(EntityRef<Member>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
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
					if (this._Member.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dailyMeal", DbType="Int NOT NULL")]
		public int dailyMeal
		{
			get
			{
				return this._dailyMeal;
			}
			set
			{
				if ((this._dailyMeal != value))
				{
					this.OndailyMealChanging(value);
					this.SendPropertyChanging();
					this._dailyMeal = value;
					this.SendPropertyChanged("dailyMeal");
					this.OndailyMealChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Member_MealList", Storage="_Member", ThisKey="id", OtherKey="id", IsForeignKey=true)]
		public Member Member
		{
			get
			{
				return this._Member.Entity;
			}
			set
			{
				Member previousValue = this._Member.Entity;
				if (((previousValue != value) 
							|| (this._Member.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Member.Entity = null;
						previousValue.MealList = null;
					}
					this._Member.Entity = value;
					if ((value != null))
					{
						value.MealList = this;
						this._id = value.id;
					}
					else
					{
						this._id = default(int);
					}
					this.SendPropertyChanged("Member");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TotalCal")]
	public partial class TotalCal : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private int _NumberOfMeal;
		
		private int _Deposit;
		
		private int _Cost;
		
		private int _Balance;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnNumberOfMealChanging(int value);
    partial void OnNumberOfMealChanged();
    partial void OnDepositChanging(int value);
    partial void OnDepositChanged();
    partial void OnCostChanging(int value);
    partial void OnCostChanged();
    partial void OnBalanceChanging(int value);
    partial void OnBalanceChanged();
    #endregion
		
		public TotalCal()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NumberOfMeal", DbType="Int NOT NULL")]
		public int NumberOfMeal
		{
			get
			{
				return this._NumberOfMeal;
			}
			set
			{
				if ((this._NumberOfMeal != value))
				{
					this.OnNumberOfMealChanging(value);
					this.SendPropertyChanging();
					this._NumberOfMeal = value;
					this.SendPropertyChanged("NumberOfMeal");
					this.OnNumberOfMealChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Deposit", DbType="Int NOT NULL")]
		public int Deposit
		{
			get
			{
				return this._Deposit;
			}
			set
			{
				if ((this._Deposit != value))
				{
					this.OnDepositChanging(value);
					this.SendPropertyChanging();
					this._Deposit = value;
					this.SendPropertyChanged("Deposit");
					this.OnDepositChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cost", DbType="Int NOT NULL")]
		public int Cost
		{
			get
			{
				return this._Cost;
			}
			set
			{
				if ((this._Cost != value))
				{
					this.OnCostChanging(value);
					this.SendPropertyChanging();
					this._Cost = value;
					this.SendPropertyChanged("Cost");
					this.OnCostChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Balance", DbType="Int NOT NULL")]
		public int Balance
		{
			get
			{
				return this._Balance;
			}
			set
			{
				if ((this._Balance != value))
				{
					this.OnBalanceChanging(value);
					this.SendPropertyChanging();
					this._Balance = value;
					this.SendPropertyChanged("Balance");
					this.OnBalanceChanged();
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
