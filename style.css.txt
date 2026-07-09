/* ==========================
   SS WORLD WIDE EXPRESS
   Professional Logistics Theme
========================== */

*{
    margin:0;
    padding:0;
    box-sizing:border-box;
    font-family:'Poppins',sans-serif;
}

html{
    scroll-behavior:smooth;
}

body{
    background:#f5f8fc;
    color:#222;
}

/* ==========================
NAVBAR
========================== */

header{
    position:fixed;
    width:100%;
    top:0;
    left:0;
    z-index:999;
    background:white;
    box-shadow:0 3px 15px rgba(0,0,0,.08);
}

.container{
    width:90%;
    max-width:1300px;
    margin:auto;
}

header .container{
    display:flex;
    justify-content:space-between;
    align-items:center;
    padding:18px 0;
}

.logo img{
    height:70px;
}

nav ul{
    display:flex;
    list-style:none;
}

nav ul li{
    margin-left:35px;
}

nav ul li a{
    text-decoration:none;
    color:#003366;
    font-weight:600;
    transition:.3s;
}

nav ul li a:hover{
    color:#ff8800;
}

/* ==========================
HERO
========================== */

.hero{
    height:100vh;
    background:
    linear-gradient(rgba(0,40,90,.75),
    rgba(0,40,90,.75)),
    url("images/hero-bg.jpg");
    background-size:cover;
    background-position:center;
    display:flex;
    justify-content:center;
    align-items:center;
    text-align:center;
}

.overlay{
    color:white;
}

.overlay h1{
    font-size:60px;
    margin-bottom:20px;
}

.overlay p{
    font-size:22px;
    margin-bottom:40px;
}

.btn{
    display:inline-block;
    padding:15px 45px;
    border-radius:50px;
    background:#ff8800;
    color:white;
    text-decoration:none;
    font-weight:600;
    transition:.4s;
}

.btn:hover{
    background:#ffaa33;
    transform:translateY(-4px);
}

/* ==========================
TRACKING
========================== */

.tracking{
    padding:90px 20px;
    text-align:center;
    background:white;
}

.tracking h2{
    font-size:40px;
    color:#003366;
}

.tracking p{
    margin:20px 0;
}

.tracking-box{
    display:flex;
    justify-content:center;
    flex-wrap:wrap;
    gap:15px;
    margin-top:30px;
}

.tracking-box input{
    width:420px;
    max-width:90%;
    padding:18px;
    border:2px solid #ddd;
    border-radius:40px;
    font-size:17px;
}

.tracking-box button{
    border:none;
    background:#003366;
    color:white;
    padding:18px 35px;
    border-radius:40px;
    cursor:pointer;
    transition:.3s;
}

.tracking-box button:hover{
    background:#ff8800;
}

/* ==========================
ABOUT
========================== */

.about{
    padding:100px 10%;
    background:#f8fbff;
}

.about h2{
    text-align:center;
    font-size:40px;
    color:#003366;
    margin-bottom:30px;
}

.about p{
    max-width:950px;
    margin:auto;
    line-height:2;
    text-align:center;
    font-size:18px;
}