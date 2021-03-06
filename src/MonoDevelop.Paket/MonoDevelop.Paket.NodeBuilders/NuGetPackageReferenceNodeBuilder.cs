﻿//
// NuGetPackageReferenceNodeBuilder.cs
//
// Author:
//       Matt Ward <ward..matt@gmail.com>
//
// Copyright (c) 2015 Matthew Ward
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//

using System;
using MonoDevelop.Ide.Gui.Components;

namespace MonoDevelop.Paket.NodeBuilders
{
	public class NuGetPackageReferenceNodeBuilder : TypeNodeBuilder
	{
		public override Type NodeDataType {
			get { return typeof(NuGetPackageReferenceNode); }
		}

		public override Type CommandHandlerType {
			get { return typeof(NuGetPackageReferenceNodeCommandHandler); }
		}

		public override string ContextMenuAddinPath {
			get { return "/MonoDevelop/Paket/ContextMenu/ProjectPad/NuGetPackageReference"; }
		}

		public override string GetNodeName (ITreeNavigator thisNode, object dataObject)
		{
			var node = (NuGetPackageReferenceNode)dataObject;
			return node.Name;
		}

		public override void BuildNode (ITreeBuilder treeBuilder, object dataObject, NodeInfo nodeInfo)
		{
			var node = (NuGetPackageReferenceNode)dataObject;
			nodeInfo.Label = node.GetLabel ();
			nodeInfo.Icon = Context.GetIcon (node.GetIconId ());
		}
	}
}

