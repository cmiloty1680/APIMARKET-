function Btn({type,style,nameBtn}) {
    return ( 
        <button type={type}
        className={style}>{nameBtn}
        </button>
     );
}

export default Btn;