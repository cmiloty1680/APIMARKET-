function Img({src,style,alt}) {
    return (
        <img src={src} className={style} alt={alt}/>
      );
}

export default Img;