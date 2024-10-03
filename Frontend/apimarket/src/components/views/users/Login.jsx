import TitleH1 from "@/components/utilities/titles/titleH1";
import Btn from "@/components/utilities/buttons/Btn";
import A from "@/components/utilities/links/A";
import Img from "@/components/utilities/fot/Img";

function Login() {
    return (
        <>
            <form className="com shadow-lg" action="sidebar">
                <div className="mb-3">
                    <Img src={"./assets/img/icon.png"} style={"fot"} alt={"error carga"}/>
                    <TitleH1 title="Iniciar Sesión" styles=""/>
                    <img src="./assets/img/person-outline.svg" alt="error" width="25" height="25"/>
                    <label htmlFor="exampleInputEmail1" className="form-label">Usuario</label>
                    <input type="email" className="form-control" placeholder=". . . . . . . . . . . . . . . . " id="exampleInputEmail1" aria-describedby="emailHelp" required/>
                </div>
                <div className="mb-3">
                    <img src="./assets/img/lock-closed-outline.svg" alt="error" width="25" height="25"/>
                    <label htmlFor="exampleInputPassword1" className="form-label">Contraseña</label>
                    <input type="password" className="form-control" placeholder=". . . . . . . . . . . . . . . . " id="exampleInputPassword1" required/>
                </div>
                <div className="bag">
                    <Btn type={"submit"} style={"btn"} nameBtn={"Ingresar"}/>
                    <A  texto="Olvidé mi contraseña" href="resstpassword" style={"link"}/>
                    <A  texto="Crear Cuenta" href="createuser" style={"links"}/>
                </div>
            </form>

        </>
      );
}

export default Login;