import React from 'react';
import './MessageCard.css'; // Archivo CSS para estilos personalizados
import PdfComponent from '../PdfComponent/PdfComponent'

const MessageCard = ({ item, index, isChecked}) => {
    return (
        <div>
            <h3 className="message-title">Generate {item.type}</h3>
            <p className="message-subtitle">{item.type + ' ' + item.message}  {isChecked(index) ? (<span className="badge badge-success">Completado</span>) : ''} </p>
            <div>
                <PdfComponent mostrar={item.downloadPdf} />
            </div>
            <p className="message-content">Submitted On:{item.submittedOn}</p>
        </div>
    );
};

export default MessageCard;