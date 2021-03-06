﻿using UnityEngine;
using System.Collections;

public class ImageContainer {
	public Tile startTile;
	public Tile endTile;
	Photo photo;
	double normalizedWidth;
	double normalizedHeight;
	double gap;
	double y;
	GameObject photoFrame;
	ImageContainer next=null;

	public ImageContainer(Tile start,Tile end){
		this.startTile=start;
		this.endTile=end;
	}

	public ImageContainer(Photo photo,double normalizedWidth,double normalizedHeight){
		this.photo=photo;
		this.normalizedWidth=normalizedWidth;
		this.normalizedHeight=normalizedHeight;
	}

	public double getWidth(){
		return normalizedWidth+2*gap;
	}	

	public void setNext(ImageContainer imageContainer){
		next=imageContainer;
	}

	public ImageContainer getNext(){
		return next;
	}
}
