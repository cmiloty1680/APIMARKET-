//funcion invocada


function PublicNav() {
    return ( 
        <>
            <nav className="navbar bg-nav-public shadow-sm">
                <div className="container">
                    <a className="navbar-brand" href="#">
                        <img src="./assets/img/icon.png" alt="Bootstrap" width="75" height="75"/>
                    </a>
                    <ul className="nav justify-content-center">
                        <li>
                            <a className="nav" href="#">Quienes somos</a>
                        </li>
                        <li>
                            <a className="nav" href="#">Proyecto</a>
                        </li>
                        <li>
                            <a className="nav" href="#">Manual de usuario</a>
                        </li>
                    <button className="button btn-pri"><a className="ingresar" href="login">ingresar</a></button> 
                    </ul>
                </div>
                
            </nav>
                
        
        </>
     );
}

export default PublicNav;