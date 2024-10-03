import TitleH2 from "@/components/utilities/titles/TitleH2";
import Btn from "@/components/utilities/buttons/Btn";
import Img from "@/components/utilities/fot/Img";


function create() {
    return (
        <>


            <form className="formu shadow-lg" >
                <TitleH2 title="Registrate" styles="" />
                <hr />
                <div className="let">
                    <div className="input-group">
                        <div className="inp">
                            <div className="input-container">
                                <input type="text" className="form-control shadow-sm" placeholder="Nombre" id="I" required />
                                <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" className="kit-icon" viewBox="0 0 16 16">
                                    <path fill-rule="evenodd" d="M2.5 12a.5.5 0 0 1 .5-.5h10a.5.5 0 0 1 0 1H3a.5.5 0 0 1-.5-.5m0-4a.5.5 0 0 1 .5-.5h10a.5.5 0 0 1 0 1H3a.5.5 0 0 1-.5-.5m0-4a.5.5 0 0 1 .5-.5h10a.5.5 0 0 1 0 1H3a.5.5 0 0 1-.5-.5" />
                                </svg>
                            </div>
                            <div className="input-container">
                                <input type="text" className="form-control shadow-sm" placeholder="Apellido" id="I" required />
                                <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" className="kit-icon" viewBox="0 0 16 16">
                                    <path fill-rule="evenodd" d="M4.5 11.5A.5.5 0 0 1 5 11h10a.5.5 0 0 1 0 1H5a.5.5 0 0 1-.5-.5m-2-4A.5.5 0 0 1 3 7h10a.5.5 0 0 1 0 1H3a.5.5 0 0 1-.5-.5m-2-4A.5.5 0 0 1 1 3h10a.5.5 0 0 1 0 1H1a.5.5 0 0 1-.5-.5" />
                                </svg>
                            </div>
                            <div className="input-container">
                                <input type="email" className="form-control shadow-sm" placeholder="Email" id="I" required />
                                <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" className="kit-icon" viewBox="0 0 16 16">
                                    <path d="M0 4a2 2 0 0 1 2-2h12a2 2 0 0 1 2 2v8a2 2 0 0 1-2 2H2a2 2 0 0 1-2-2zm2-1a1 1 0 0 0-1 1v.217l7 4.2 7-4.2V4a1 1 0 0 0-1-1zm13 2.383-4.708 2.825L15 11.105zm-.034 6.876-5.64-3.471L8 9.583l-1.326-.795-5.64 3.47A1 1 0 0 0 2 13h12a1 1 0 0 0 .966-.741M1 11.105l4.708-2.897L1 5.383z" />
                                </svg>
                            </div>
                            <div className="input-container">
                                <input type="password" className="form-control shadow-sm" placeholder="Contraseña" id="I" required />
                                <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" className="kit-icon" viewBox="0 0 16 16">
                                    <path d="M8 1a2 2 0 0 1 2 2v4H6V3a2 2 0 0 1 2-2m3 6V3a3 3 0 0 0-6 0v4a2 2 0 0 0-2 2v5a2 2 0 0 0 2 2h6a2 2 0 0 0 2-2V9a2 2 0 0 0-2-2" />
                                </svg>
                            </div>
                        </div>
                    </div>

                    <Btn type={"submit"} style={"btn"} nameBtn={"Crear cuenta"} />

                </div>
                <Img src={"./assets/img/icon.png"} style={"imagen"} alt={"error carga"} />


            </form>
        </>
    );
}

export default create;