import React, { useState } from 'react';
import { Modal, ModalHeader, ModalBody } from 'reactstrap';
import { FaCheckCircle, FaCircle, FaExclamationCircle } from 'react-icons/fa'; // Importa los íconos que desees
import MessageCard from './MessageCard';
import './ReviewTable.css'; // Archivo CSS para estilos personalizados
import 'bootstrap/dist/css/bootstrap.min.css';

const data = [
  {
    type: "t4",
    message: "for 22 been completed",
    submittedOn: "08 nov 2021",
    downloadPdf: true
  },
  {
    type: "t5",
    message: "for 22 been completed",
    submittedOn: "09 nov 2021",
    downloadPdf: false
  },
  {
    type: "t6",
    message: "for 22 been completed",
    submittedOn: "09 nov 2021",
    downloadPdf: false
  },
  {
    type: "t7",
    message: "for 22 been completed",
    submittedOn: "09 nov 2021",
    downloadPdf: false
  }
  // Agrega más objetos según sea necesario
];

const ReviewTable = () => {
  const [modal, setModal] = useState(false);
  const [selectedType, setSelectedType] = useState(null);
  const [selectedRow, setSelectedRow] = useState(null);
  const [checkedRows, setCheckedRows] = useState([]);

  const toggleModal = (type) => {
    setSelectedType(type);
    setModal(!modal);
  };

  const handleRowClick = (index) => {
    setSelectedRow(index);
  };

  const handleReviewClick = (index, type) => {
    toggleModal(type);
    setCheckedRows([...checkedRows, index]);
  };

  const isChecked = (index) => {
    return checkedRows.includes(index);
  };

  return (
    <div className="container">
      
      <button className="icon-button-text">
        <span className="icon-container">
          <FaCheckCircle className="icon" />
        </span>
        2024 Jairo Flores
      </button>

      {data.map((item, index) => (
        <div
          key={index}
          className="d-flex justify-content-between align-items-center p-2 mb-2"
          style={{ backgroundColor: selectedRow === index ? '#EDF1F5' : 'transparent' }}
          onMouseEnter={() => handleRowClick(index)}
        >
          <button className="btn btn-success">
            <span className="icon-background">
              {isChecked(index) ? <FaCheckCircle /> : <FaCircle />}
            </span>
          </button>
          <div>
            <MessageCard item={item} />
          </div>
          <button
            className="transparent-button"
            onClick={() => handleReviewClick(index, item.type)}
          >
            Review {item.type}
          </button>
        </div>
      ))}
      <Modal isOpen={modal} toggle={() => toggleModal(null)}>
        <ModalHeader toggle={() => toggleModal(null)}>Review {selectedType} Selected</ModalHeader>
        <ModalBody>
          <p>You have selected {selectedType} for review.</p>
        </ModalBody>
      </Modal>
    </div>
  );
};

export default ReviewTable;
