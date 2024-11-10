import React, { useState } from 'react';
import './ClientForm.scss';

const MyForm = () => {
  const [formData, setFormData] = useState({
    name: '',
    id: 0,
    therapistID:0
  });

  const handleChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    const { name, value } = e.target;
    setFormData({
      ...formData,
      [name]: value
    });
  };

  const handleSubmit = (e: React.FormEvent<HTMLFormElement>) => {
    e.preventDefault();
    // פעולות שאתה רוצה לבצע כאשר הטופס נשלח
  };

  return (
    <div style={{ float: 'right', marginRight: '20px' }}>
      <form onSubmit={handleSubmit}>
        <h2>Form for adding a patient:</h2>
        <br></br>
        <label>
          Name:
          <input type="text" name="name" value={formData.name} onChange={handleChange} />
        </label>
        <br />
        <label>
          ID:
          <input type="text" name="id" value={formData.id} onChange={handleChange} />
        </label>
        <br />
        <label>
          Therapist ID:
          <input type="text" name="therapistID" value={formData.therapistID} onChange={handleChange} />
        </label>
        <br />
        <button type="submit">Submit</button>
      </form>
    </div>
  );
};

export default MyForm;