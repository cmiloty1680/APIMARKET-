import localFont from "next/font/local";

//importacion de estilos de boostrap
import "bootstrap/dist/css/bootstrap.min.css"
//style globales

import "./globals.css";

const geistSans = localFont({
  src: "./fonts/GeistVF.woff",
  variable: "--font-geist-sans",
  weight: "100 900",
});
const geistMono = localFont({
  src: "./fonts/GeistMonoVF.woff",
  variable: "--font-geist-mono",
  weight: "100 900",
});

export const metadata = {
  title: "APIMARKET",
  description: "Proyecto enfocado a las actividades de la unidad de apicultura",
  icons:{
    icon: "./assets/img/"
  }
};

export default function RootLayout({ children }) {
  return (
    <html lang="en">
      <body className={`${geistSans.variable} ${geistMono.variable}`}>
        {children}
      </body>
    </html>
  );
}
