﻿//
// Copyright 2018 NEM
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// 

using io.nem2.sdk.Model.Blockchain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test.Model.BlockchainTests
{
    [TestClass]
    public class NetworkTypeTests
    {
        [TestMethod]
        public void MAIN_NETIs0x68()
        {
            Assert.IsTrue(0x68 == NetworkType.Types.MAIN_NET.GetNetworkByte());
            Assert.IsTrue(104 == NetworkType.Types.MAIN_NET.GetNetworkByte());
        }

        [TestMethod]
        public void TEST_NETIs0x96()
        {
            Assert.IsTrue(0x98 == NetworkType.Types.TEST_NET.GetNetworkByte());
            Assert.IsTrue(152 == NetworkType.Types.TEST_NET.GetNetworkByte());
        }

        [TestMethod]
        public void MIJINIs0x60()
        {
            Assert.IsTrue(0x60 == NetworkType.Types.MIJIN.GetNetworkByte());
            Assert.IsTrue(96 == NetworkType.Types.MIJIN.GetNetworkByte());
        }

        [TestMethod]
        public void MIJIN_TESTIs0x90()
        {
            Assert.IsTrue(0x90 == NetworkType.Types.MIJIN_TEST.GetNetworkByte());
            Assert.IsTrue(144 == NetworkType.Types.MIJIN_TEST.GetNetworkByte());
        }
    }
}
