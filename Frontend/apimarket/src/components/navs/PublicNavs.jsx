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
                    </ul>
                </div>
                <a href="nave"><svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" className="exit" viewBox="0 0 16 16">
                    <path fill-rule="evenodd" d="M15 2a1 1 0 0 0-1-1H2a1 1 0 0 0-1 1v12a1 1 0 0 0 1 1h12a1 1 0 0 0 1-1zM0 2a2 2 0 0 1 2-2h12a2 2 0 0 1 2 2v12a2 2 0 0 1-2 2H2a2 2 0 0 1-2-2zm4.5 5.5a.5.5 0 0 0 0 1h5.793l-2.147 2.146a.5.5 0 0 0 .708.708l3-3a.5.5 0 0 0 0-.708l-3-3a.5.5 0 1 0-.708.708L10.293 7.5z"/>
                    </svg></a>

            </nav>
                
        
        </>
     );
}

export default PublicNav;