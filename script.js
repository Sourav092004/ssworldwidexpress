// =====================================
// SS WORLD WIDE EXPRESS
// script.js
// =====================================


// ===============================
// SHIPMENT TRACKING
// ===============================

function trackShipment() {

    const tracking = document
        .getElementById("trackingNumber")
        .value
        .trim();

    if (tracking === "") {

        alert("Please enter your Tracking Number.");
        return;

    }

    /*
    ----------------------------------------
    Future API Integration

    DHL
    FedEx
    UPS
    Trackon

    Replace this section later with API calls.
    ----------------------------------------
    */

    window.open(
        "https://www.17track.net/en#nums=" + tracking,
        "_blank"
    );

}



// ===============================
// SMOOTH SCROLL
// ===============================

document.querySelectorAll('a[href^="#"]').forEach(anchor => {

    anchor.addEventListener("click", function (e) {

        e.preventDefault();

        const target = document.querySelector(this.getAttribute("href"));

        if(target){

            target.scrollIntoView({

                behavior:"smooth"

            });

        }

    });

});



// ===============================
// NAVBAR SHADOW
// ===============================

window.addEventListener("scroll", function(){

    const header = document.querySelector("header");

    if(window.scrollY > 80){

        header.style.boxShadow="0 10px 25px rgba(0,0,0,.15)";

    }

    else{

        header.style.boxShadow="0 3px 15px rgba(0,0,0,.08)";

    }

});




// ===============================
// ACTIVE MENU
// ===============================

const sections = document.querySelectorAll("section");

const navLinks = document.querySelectorAll("nav ul li a");

window.addEventListener("scroll",()=>{

    let current="";

    sections.forEach(section=>{

        const top = section.offsetTop-150;

        if(pageYOffset>=top){

            current=section.getAttribute("id");

        }

    });

    navLinks.forEach(link=>{

        link.classList.remove("active");

        if(link.getAttribute("href")=="#"+current){

            link.classList.add("active");

        }

    });

});




// ===============================
// QUOTE FORM
// ===============================

const form=document.querySelector("form");

if(form){

form.addEventListener("submit",function(e){

    e.preventDefault();

    alert("Thank you! We have received your enquiry.\n\nOur team will contact you shortly.");

    form.reset();

});

}




// ===============================
// FADE-IN ANIMATION
// ===============================

const observer=new IntersectionObserver(entries=>{

entries.forEach(entry=>{

if(entry.isIntersecting){

entry.target.classList.add("show");

}

});

},{threshold:.15});


document.querySelectorAll(".card,.why-grid div,.about,.quote,.contact").forEach(el=>{

observer.observe(el);

});




// ===============================
// BACK TO TOP BUTTON
// ===============================

const topButton=document.createElement("button");

topButton.innerHTML="⬆";

topButton.id="topButton";

document.body.appendChild(topButton);


topButton.style.position="fixed";
topButton.style.right="25px";
topButton.style.bottom="30px";
topButton.style.width="50px";
topButton.style.height="50px";
topButton.style.borderRadius="50%";
topButton.style.border="none";
topButton.style.background="#003366";
topButton.style.color="#fff";
topButton.style.fontSize="20px";
topButton.style.cursor="pointer";
topButton.style.display="none";
topButton.style.zIndex="9999";


window.addEventListener("scroll",()=>{

if(window.scrollY>400){

topButton.style.display="block";

}else{

topButton.style.display="none";

}

});


topButton.addEventListener("click",()=>{

window.scrollTo({

top:0,

behavior:"smooth"

});

});




// ===============================
// WHATSAPP BUTTON ANIMATION
// ===============================

const whatsapp=document.querySelector(".whatsapp");

if(whatsapp){

setInterval(()=>{

whatsapp.style.transform="scale(1.15)";

setTimeout(()=>{

whatsapp.style.transform="scale(1)";

},400);

},2500);

}




// ===============================
// PRELOADER READY
// ===============================

window.addEventListener("load",()=>{

console.log("SS World Wide Express Website Loaded Successfully");

});
