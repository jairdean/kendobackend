import React from 'react';
import { FaFilePdf } from 'react-icons/fa'; // Importa el icono de PDF
import './Pdf.css'; // Archivo CSS para estilos personalizados

const PdfComponent = ({ mostrar }) => {
    return (
        <div className="centered-container">
            {mostrar && (
                <a href="https://www.antennahouse.com/hubfs/xsl-fo-sample/pdf/basic-link-1.pdf" download="documento.pdf" className="download-link">
                    <FaFilePdf className="pdf-icon" />
                    Download PDF
                </a>
            )}
        </div>
    );
};

export default PdfComponent;
