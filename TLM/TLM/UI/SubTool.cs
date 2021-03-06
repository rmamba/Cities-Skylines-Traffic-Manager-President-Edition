﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace TrafficManager.UI {
	public abstract class SubTool {
		public TrafficManagerTool MainTool { get; set; }

		protected ushort HoveredNodeId {
			get { return MainTool.HoveredNodeId; }
			set { MainTool.HoveredNodeId = value; }
		}

		protected ushort HoveredSegmentId {
			get { return MainTool.HoveredSegmentId; }
			set { MainTool.HoveredSegmentId = value; }
		}

		protected ushort SelectedNodeId {
			get { return TrafficManagerTool.SelectedNodeId; }
			set { TrafficManagerTool.SelectedNodeId = value; }
		}

		protected ushort SelectedSegmentId {
			get { return TrafficManagerTool.SelectedSegmentId; }
			set { TrafficManagerTool.SelectedSegmentId = value; }
		}

		public SubTool(TrafficManagerTool mainTool) {
			MainTool = mainTool;
		}

		public void OnToolUpdate() {
			OnClickOverlay();
		}

		public abstract void OnClickOverlay();
		public abstract void OnToolGUI(Event e);
		public abstract void RenderOverlay(RenderManager.CameraInfo cameraInfo);
		public virtual void Cleanup() { }
		public virtual void OnActivate() { }
		public virtual void ShowIcons() { }
		public virtual bool IsCursorInPanel() {
			return false;
		}
	}
}
