/* Changes the background image of the div*/

function upDate(previewPic){
 
		document.getElementById('image').innerHTML = previewPic.alt;
		document.getElementById('image').style.backgroundImage= "url(" + previewPic.src + ")";

	}

/* Returns the div to its original form*/
	function unDo(){
    
		document.getElementById('image').innerHTML = "Hover over an image below to display here.";
		document.getElementById('image').style.backgroundImage = "url('')";
	}
