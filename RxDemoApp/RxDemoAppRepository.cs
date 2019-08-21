﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace RxDemoApp
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the RxDemoAppRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.3")]
    [RepositoryFolder("ffc03627-3993-402b-84ae-603084ab166f")]
    public partial class RxDemoAppRepository : RepoGenBaseFolder
    {
        static RxDemoAppRepository instance = new RxDemoAppRepository();
        RxDemoAppRepositoryFolders.ApplicationUnderTestAppFolder _applicationundertest;
        RxDemoAppRepositoryFolders.List1000AppFolder _list1000;

        /// <summary>
        /// Gets the singleton class instance representing the RxDemoAppRepository element repository.
        /// </summary>
        [RepositoryFolder("ffc03627-3993-402b-84ae-603084ab166f")]
        public static RxDemoAppRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public RxDemoAppRepository() 
            : base("RxDemoAppRepository", "/", null, 0, false, "ffc03627-3993-402b-84ae-603084ab166f", ".\\RepositoryImages\\RxDemoAppRepositoryffc03627.rximgres")
        {
            _applicationundertest = new RxDemoAppRepositoryFolders.ApplicationUnderTestAppFolder(this);
            _list1000 = new RxDemoAppRepositoryFolders.List1000AppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("ffc03627-3993-402b-84ae-603084ab166f")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The ApplicationUnderTest folder.
        /// </summary>
        [RepositoryFolder("b804ed16-e906-4cd3-a0e7-13fdf80e772b")]
        public virtual RxDemoAppRepositoryFolders.ApplicationUnderTestAppFolder ApplicationUnderTest
        {
            get { return _applicationundertest; }
        }

        /// <summary>
        /// The List1000 folder.
        /// </summary>
        [RepositoryFolder("5bd60fe7-c45b-4bd7-a08f-4773245f6db4")]
        public virtual RxDemoAppRepositoryFolders.List1000AppFolder List1000
        {
            get { return _list1000; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.3")]
    public partial class RxDemoAppRepositoryFolders
    {
        /// <summary>
        /// The ApplicationUnderTestAppFolder folder.
        /// </summary>
        [RepositoryFolder("b804ed16-e906-4cd3-a0e7-13fdf80e772b")]
        public partial class ApplicationUnderTestAppFolder : RepoGenBaseFolder
        {
            RxDemoAppRepositoryFolders.RxTabIntroductionFolder _rxtabintroduction;
            RxDemoAppRepositoryFolders.RxTabStandardFolder _rxtabstandard;
            RepoItemInfo _testdatabaseInfo;

            /// <summary>
            /// Creates a new ApplicationUnderTest  folder.
            /// </summary>
            public ApplicationUnderTestAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ApplicationUnderTest", "/form[@processname='RxDemoApp']", parentFolder, 30000, null, true, "b804ed16-e906-4cd3-a0e7-13fdf80e772b", "")
            {
                _rxtabintroduction = new RxDemoAppRepositoryFolders.RxTabIntroductionFolder(this);
                _rxtabstandard = new RxDemoAppRepositoryFolders.RxTabStandardFolder(this);
                _testdatabaseInfo = new RepoItemInfo(this, "TestDatabase", "?/?/tabpage[@accessiblename='Test database']", 30000, null, "f98ca74b-8006-42f5-947f-163f69193061");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("b804ed16-e906-4cd3-a0e7-13fdf80e772b")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("b804ed16-e906-4cd3-a0e7-13fdf80e772b")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The TestDatabase item.
            /// </summary>
            [RepositoryItem("f98ca74b-8006-42f5-947f-163f69193061")]
            public virtual Ranorex.TabPage TestDatabase
            {
                get
                {
                    return _testdatabaseInfo.CreateAdapter<Ranorex.TabPage>(true);
                }
            }

            /// <summary>
            /// The TestDatabase item info.
            /// </summary>
            [RepositoryItemInfo("f98ca74b-8006-42f5-947f-163f69193061")]
            public virtual RepoItemInfo TestDatabaseInfo
            {
                get
                {
                    return _testdatabaseInfo;
                }
            }

            /// <summary>
            /// The RxTabIntroduction folder.
            /// </summary>
            [RepositoryFolder("776be3d2-ebde-43f9-8893-167d4a903c32")]
            public virtual RxDemoAppRepositoryFolders.RxTabIntroductionFolder RxTabIntroduction
            {
                get { return _rxtabintroduction; }
            }

            /// <summary>
            /// The RxTabStandard folder.
            /// </summary>
            [RepositoryFolder("986e6f58-76fb-4289-9c3a-fec85da1991e")]
            public virtual RxDemoAppRepositoryFolders.RxTabStandardFolder RxTabStandard
            {
                get { return _rxtabstandard; }
            }
        }

        /// <summary>
        /// The RxTabIntroductionFolder folder.
        /// </summary>
        [RepositoryFolder("776be3d2-ebde-43f9-8893-167d4a903c32")]
        public partial class RxTabIntroductionFolder : RepoGenBaseFolder
        {
            RepoItemInfo _enteryournameInfo;
            RepoItemInfo _btnsubmitusernameInfo;
            RepoItemInfo _lblwelcomemessageInfo;

            /// <summary>
            /// Creates a new RxTabIntroduction  folder.
            /// </summary>
            public RxTabIntroductionFolder(RepoGenBaseFolder parentFolder) :
                    base("RxTabIntroduction", "?/?/tabpage[@controlname='RxTabIntroduction']", parentFolder, 30000, null, false, "776be3d2-ebde-43f9-8893-167d4a903c32", "")
            {
                _enteryournameInfo = new RepoItemInfo(this, "EnterYourName", "?/?/text[@accessiblename='Enter your name']", 30000, null, "1709549b-4e66-4e51-b339-596e35244f85");
                _btnsubmitusernameInfo = new RepoItemInfo(this, "BtnSubmitUserName", "button[@controlname='btnSubmitUserName']", 30000, null, "07093c63-aedc-4fcd-b097-14d9fcd0de65");
                _lblwelcomemessageInfo = new RepoItemInfo(this, "LblWelcomeMessage", "text[@controlname='lblWelcomeMessage']", 30000, null, "87fd0376-bba7-4c35-9856-f8cb89c2ec06");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("776be3d2-ebde-43f9-8893-167d4a903c32")]
            public virtual Ranorex.TabPage Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.TabPage>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("776be3d2-ebde-43f9-8893-167d4a903c32")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The EnterYourName item.
            /// </summary>
            [RepositoryItem("1709549b-4e66-4e51-b339-596e35244f85")]
            public virtual Ranorex.Text EnterYourName
            {
                get
                {
                    return _enteryournameInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The EnterYourName item info.
            /// </summary>
            [RepositoryItemInfo("1709549b-4e66-4e51-b339-596e35244f85")]
            public virtual RepoItemInfo EnterYourNameInfo
            {
                get
                {
                    return _enteryournameInfo;
                }
            }

            /// <summary>
            /// The BtnSubmitUserName item.
            /// </summary>
            [RepositoryItem("07093c63-aedc-4fcd-b097-14d9fcd0de65")]
            public virtual Ranorex.Button BtnSubmitUserName
            {
                get
                {
                    return _btnsubmitusernameInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The BtnSubmitUserName item info.
            /// </summary>
            [RepositoryItemInfo("07093c63-aedc-4fcd-b097-14d9fcd0de65")]
            public virtual RepoItemInfo BtnSubmitUserNameInfo
            {
                get
                {
                    return _btnsubmitusernameInfo;
                }
            }

            /// <summary>
            /// The LblWelcomeMessage item.
            /// </summary>
            [RepositoryItem("87fd0376-bba7-4c35-9856-f8cb89c2ec06")]
            public virtual Ranorex.Text LblWelcomeMessage
            {
                get
                {
                    return _lblwelcomemessageInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The LblWelcomeMessage item info.
            /// </summary>
            [RepositoryItemInfo("87fd0376-bba7-4c35-9856-f8cb89c2ec06")]
            public virtual RepoItemInfo LblWelcomeMessageInfo
            {
                get
                {
                    return _lblwelcomemessageInfo;
                }
            }
        }

        /// <summary>
        /// The RxTabStandardFolder folder.
        /// </summary>
        [RepositoryFolder("986e6f58-76fb-4289-9c3a-fec85da1991e")]
        public partial class RxTabStandardFolder : RepoGenBaseFolder
        {
            RepoItemInfo _button開くInfo;
            RepoItemInfo _rdbmaleInfo;
            RepoItemInfo _firstnameInfo;
            RepoItemInfo _updowneditInfo;
            RepoItemInfo _btnaddpersonInfo;
            RepoItemInfo _btndeletepersonInfo;
            RepoItemInfo _taromale30projectmanagementInfo;

            /// <summary>
            /// Creates a new RxTabStandard  folder.
            /// </summary>
            public RxTabStandardFolder(RepoGenBaseFolder parentFolder) :
                    base("RxTabStandard", "?/?/tabpage[@controlname='RxTabStandard']", parentFolder, 30000, null, false, "986e6f58-76fb-4289-9c3a-fec85da1991e", "")
            {
                _button開くInfo = new RepoItemInfo(this, "Button開く", "?/?/button[@accessiblename='開く']", 30000, null, "ace73312-2fb6-4554-88f7-c769dcd9dd27");
                _rdbmaleInfo = new RepoItemInfo(this, "RdbMale", "?/?/radiobutton[@controlname='rdbMale']", 30000, null, "4f8b47d7-9494-440e-a741-71dcd8c2fa84");
                _firstnameInfo = new RepoItemInfo(this, "FirstName", "?/?/text[@accessiblename='First name']", 30000, null, "78208fcb-e3b4-4348-8d97-951c26558135");
                _updowneditInfo = new RepoItemInfo(this, "UpDownEdit", "?/?/text[@controlname='upDownEdit']", 30000, null, "56a4917f-b1eb-4475-aad8-4951b595b305");
                _btnaddpersonInfo = new RepoItemInfo(this, "BtnAddPerson", "button[@controlname='btnAddPerson']", 30000, null, "30a85796-74b1-4f7d-adfa-5d4ed611cf84");
                _btndeletepersonInfo = new RepoItemInfo(this, "BtnDeletePerson", "button[@controlname='btnDeletePerson']", 30000, null, "2c1a487d-4948-4e59-8117-295e4b96847c");
                _taromale30projectmanagementInfo = new RepoItemInfo(this, "TaroMale30ProjectManagement", "list[@controlname='lstPersonList']/?/?/listitem[@accessiblename~'^Taro\\ \\ \\(male,\\ 30\\)\\ Project\\ ']", 30000, null, "b0a0a791-71c6-432e-b16e-b7c13ad807b9");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("986e6f58-76fb-4289-9c3a-fec85da1991e")]
            public virtual Ranorex.TabPage Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.TabPage>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("986e6f58-76fb-4289-9c3a-fec85da1991e")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Button開く item.
            /// </summary>
            [RepositoryItem("ace73312-2fb6-4554-88f7-c769dcd9dd27")]
            public virtual Ranorex.Button Button開く
            {
                get
                {
                    return _button開くInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Button開く item info.
            /// </summary>
            [RepositoryItemInfo("ace73312-2fb6-4554-88f7-c769dcd9dd27")]
            public virtual RepoItemInfo Button開くInfo
            {
                get
                {
                    return _button開くInfo;
                }
            }

            /// <summary>
            /// The RdbMale item.
            /// </summary>
            [RepositoryItem("4f8b47d7-9494-440e-a741-71dcd8c2fa84")]
            public virtual Ranorex.RadioButton RdbMale
            {
                get
                {
                    return _rdbmaleInfo.CreateAdapter<Ranorex.RadioButton>(true);
                }
            }

            /// <summary>
            /// The RdbMale item info.
            /// </summary>
            [RepositoryItemInfo("4f8b47d7-9494-440e-a741-71dcd8c2fa84")]
            public virtual RepoItemInfo RdbMaleInfo
            {
                get
                {
                    return _rdbmaleInfo;
                }
            }

            /// <summary>
            /// The FirstName item.
            /// </summary>
            [RepositoryItem("78208fcb-e3b4-4348-8d97-951c26558135")]
            public virtual Ranorex.Text FirstName
            {
                get
                {
                    return _firstnameInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The FirstName item info.
            /// </summary>
            [RepositoryItemInfo("78208fcb-e3b4-4348-8d97-951c26558135")]
            public virtual RepoItemInfo FirstNameInfo
            {
                get
                {
                    return _firstnameInfo;
                }
            }

            /// <summary>
            /// The UpDownEdit item.
            /// </summary>
            [RepositoryItem("56a4917f-b1eb-4475-aad8-4951b595b305")]
            public virtual Ranorex.Text UpDownEdit
            {
                get
                {
                    return _updowneditInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The UpDownEdit item info.
            /// </summary>
            [RepositoryItemInfo("56a4917f-b1eb-4475-aad8-4951b595b305")]
            public virtual RepoItemInfo UpDownEditInfo
            {
                get
                {
                    return _updowneditInfo;
                }
            }

            /// <summary>
            /// The BtnAddPerson item.
            /// </summary>
            [RepositoryItem("30a85796-74b1-4f7d-adfa-5d4ed611cf84")]
            public virtual Ranorex.Button BtnAddPerson
            {
                get
                {
                    return _btnaddpersonInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The BtnAddPerson item info.
            /// </summary>
            [RepositoryItemInfo("30a85796-74b1-4f7d-adfa-5d4ed611cf84")]
            public virtual RepoItemInfo BtnAddPersonInfo
            {
                get
                {
                    return _btnaddpersonInfo;
                }
            }

            /// <summary>
            /// The BtnDeletePerson item.
            /// </summary>
            [RepositoryItem("2c1a487d-4948-4e59-8117-295e4b96847c")]
            public virtual Ranorex.Button BtnDeletePerson
            {
                get
                {
                    return _btndeletepersonInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The BtnDeletePerson item info.
            /// </summary>
            [RepositoryItemInfo("2c1a487d-4948-4e59-8117-295e4b96847c")]
            public virtual RepoItemInfo BtnDeletePersonInfo
            {
                get
                {
                    return _btndeletepersonInfo;
                }
            }

            /// <summary>
            /// The TaroMale30ProjectManagement item.
            /// </summary>
            [RepositoryItem("b0a0a791-71c6-432e-b16e-b7c13ad807b9")]
            public virtual Ranorex.ListItem TaroMale30ProjectManagement
            {
                get
                {
                    return _taromale30projectmanagementInfo.CreateAdapter<Ranorex.ListItem>(true);
                }
            }

            /// <summary>
            /// The TaroMale30ProjectManagement item info.
            /// </summary>
            [RepositoryItemInfo("b0a0a791-71c6-432e-b16e-b7c13ad807b9")]
            public virtual RepoItemInfo TaroMale30ProjectManagementInfo
            {
                get
                {
                    return _taromale30projectmanagementInfo;
                }
            }
        }

        /// <summary>
        /// The List1000AppFolder folder.
        /// </summary>
        [RepositoryFolder("5bd60fe7-c45b-4bd7-a08f-4773245f6db4")]
        public partial class List1000AppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _projectmanagementInfo;

            /// <summary>
            /// Creates a new List1000  folder.
            /// </summary>
            public List1000AppFolder(RepoGenBaseFolder parentFolder) :
                    base("List1000", "/list[@controlid='1000']", parentFolder, 30000, null, false, "5bd60fe7-c45b-4bd7-a08f-4773245f6db4", "")
            {
                _projectmanagementInfo = new RepoItemInfo(this, "ProjectManagement", "listitem[@text='Project Management']", 30000, null, "f7969688-01ed-44c3-891a-c210749ce0e1");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("5bd60fe7-c45b-4bd7-a08f-4773245f6db4")]
            public virtual Ranorex.List Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.List>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("5bd60fe7-c45b-4bd7-a08f-4773245f6db4")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The ProjectManagement item.
            /// </summary>
            [RepositoryItem("f7969688-01ed-44c3-891a-c210749ce0e1")]
            public virtual Ranorex.ListItem ProjectManagement
            {
                get
                {
                    return _projectmanagementInfo.CreateAdapter<Ranorex.ListItem>(true);
                }
            }

            /// <summary>
            /// The ProjectManagement item info.
            /// </summary>
            [RepositoryItemInfo("f7969688-01ed-44c3-891a-c210749ce0e1")]
            public virtual RepoItemInfo ProjectManagementInfo
            {
                get
                {
                    return _projectmanagementInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}