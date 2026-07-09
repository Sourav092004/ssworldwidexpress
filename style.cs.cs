/* ===========================
   SS WORLD WIDE EXPRESS
   Modern Responsive CSS
=========================== */

*{
    margin:0;
    padding:0;
    box-sizing:border-box;
    font-family:Arial, Helvetica, sans-serif;
}

html{
    scroll-behavior:smooth;
}

body{
    background:#f5f7fb;
    color:#333;
    line-height:1.6;
}

/* HEADER */

header{
    background:#fff;
    box-shadow:0 2px 10px rgba(0,0,0,.08);
    position:sticky;
    top:0;
    z-index:1000;
}

.navbar{
    width:90%;
    max-width:1200px;
    margin:auto;
    display:flex;
    justify-content:space-between;
    align-items:center;
    padding:18px 0;
}

.logo{
    display:flex;
    align-items:center;
    gap:12px;
}

.logo img{
    height:60px;
}

.logo h2{
    color:#003b82;
    font-size:28px;
}

nav ul{
    list-style:none;
    display:flex;
    gap:30px;
}

nav ul li a{
    text-decoration:none;
    color:#003b82;
    font-weight:bold;
    transition:.3s;
}

nav ul li a:hover{
    color:#ff6600;
}

/* HERO */

.hero{
    min-height:650px;
    background:linear-gradient(rgba(0,40,90,.75),rgba(0,40,90,.75)),
    url("images/hero-bg.jpg") center center/cover no-repeat;
    display:flex;
    justify-content:center;
    align-items:center;
    text-align:center;
    color:#fff;
    padding:30px;
}

.hero h1{
    font-size:60px;
    margin-bottom:20px;
}

.hero p{
    font-size:22px;
    margin-bottom:30px;
}

.hero a{
    display:inline-block;
    background:#ff6600;
    color:#fff;
    text-decoration:none;
    padding:15px 35px;
    border-radius:50px;
    font-weight:bold;
    transition:.3s;
}

.hero a:hover{
    background:#fff;
    color:#003b82;
}

/* SECTIONS */

section{
    padding:80px 8%;
}

section h2{
    text-align:center;
    color:#003b82;
    font-size:40px;
    margin-bottom:45px;
}

/* TRACKING */

.tracking{
    background:#003b82;
    color:#fff;
    text-align:center;
}

.tracking input{
    width:350px;
    max-width:90%;
    padding:15px;
    border:none;
    border-radius:10px;
    margin:20px 10px;
}

.tracking button{
    padding:15px 30px;
    border:none;
    background:#ff6600;
    color:#fff;
    border-radius:10px;
    cursor:pointer;
    font-size:16px;
}

.tracking button:hover{
    background:#fff;
    color:#003b82;
}

/* ABOUT */

.about{
    max-width:1100px;
    margin:auto;
    text-align:center;
    font-size:19px;
}

/* SERVICES */

.service-grid{
    display:grid;
    grid-template-columns:repeat(auto-fit,minmax(260px,1fr));
    gap:25px;
}

.card{
    background:#fff;
    padding:30px;
    border-radius:15px;
    text-align:center;
    box-shadow:0 10px 20px rgba(0,0,0,.08);
    transition:.3s;
}

.card:hover{
    transform:translateY(-8px);
}

.card h3{
    color:#003b82;
    margin-bottom:15px;
}

/* WHY US */

.why{
    background:#003b82;
    color:#fff;
}

.why-grid{
    display:grid;
    grid-template-columns:repeat(auto-fit,minmax(220px,1fr));
    gap:20px;
}

.why-grid div{
    background:rgba(255,255,255,.1);
    padding:25px;
    border-radius:15px;
    text-align:center;
}

/* COUNTRIES */

.country-grid{
    display:grid;
    grid-template-columns:repeat(auto-fit,minmax(180px,1fr));
    gap:20px;
}

.country-card{
    background:#fff;
    padding:25px;
    border-radius:12px;
    text-align:center;
    box-shadow:0 5px 15px rgba(0,0,0,.08);
    font-weight:bold;
}

/* STATS */

.stats{
    display:grid;
    grid-template-columns:repeat(auto-fit,minmax(220px,1fr));
    gap:20px;
    background:#003b82;
    color:#fff;
    text-align:center;
}

.stat{
    padding:35px;
}

.stat h1{
    font-size:50px;
    color:#ff9900;
}

/* TESTIMONIALS */

.testimonials{
    background:#fff;
}

.testimonial-card{
    max-width:800px;
    margin:25px auto;
    background:#f7f7f7;
    padding:30px;
    border-radius:15px;
    box-shadow:0 8px 20px rgba(0,0,0,.08);
}

/* FAQ */

.faq-item{
    background:#fff;
    margin-bottom:20px;
    padding:25px;
    border-radius:12px;
    box-shadow:0 5px 15px rgba(0,0,0,.08);
}

.faq-item h3{
    color:#003b82;
    margin-bottom:10px;
}

/* CONTACT */

.contact{
    background:#003b82;
    color:#fff;
    text-align:center;
}

.contact p{
    margin:12px 0;
}

/* FOOTER */

footer{
    background:#001d42;
    color:#fff;
    text-align:center;
    padding:25px;
}

/* WHATSAPP */

.whatsapp{
    position:fixed;
    bottom:25px;
    right:25px;
    width:65px;
    height:65px;
    border-radius:50%;
    background:#25D366;
    display:flex;
    justify-content:center;
    align-items:center;
    color:#fff;
    text-decoration:none;
    font-size:30px;
    box-shadow:0 10px 20px rgba(0,0,0,.25);
}

/* MOBILE */

@media(max-width:768px){

.hero h1{
    font-size:38px;
}

.hero p{
    font-size:18px;
}

.navbar{
    flex-direction:column;
    gap:20px;
}

nav ul{
    flex-direction:column;
    text-align:center;
}

.tracking input{
    width:100%;
}

}