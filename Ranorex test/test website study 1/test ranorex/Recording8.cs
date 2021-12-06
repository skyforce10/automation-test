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
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace test_ranorex
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording8 recording.
    /// </summary>
    [TestModule("6903bafd-88bc-4116-924d-40aeb5f8c7fe", ModuleType.Recording, 1)]
    public partial class Recording8 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the test_ranorexRepository repository.
        /// </summary>
        public static test_ranorexRepository repo = test_ranorexRepository.Instance;

        static Recording8 instance = new Recording8();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording8()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording8 Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Hesabım' at 39;2.", repo.ApplicationUnderTest.HesabımInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.Hesabım.Click("39;2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CıkışYap' at 52;2.", repo.ApplicationUnderTest.CıkışYapInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.CıkışYap.Click("52;2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest' at 1058;150.", repo.ApplicationUnderTest.SelfInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.Self.Click("1058;150");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.GirişYap' at 38;9.", repo.ApplicationUnderTest.GirişYapInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.GirişYap.Click("38;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Valid='True') on item 'ApplicationUnderTest.Login'.", repo.ApplicationUnderTest.LoginInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.ApplicationUnderTest.LoginInfo, "Valid", "True");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
