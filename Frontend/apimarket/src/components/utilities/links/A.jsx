function A({texto,href,style}) {
    return (  
        <a href={href}  rel="noopener noreferrer" className={style}>{texto}</a>
    );
}

export default A;