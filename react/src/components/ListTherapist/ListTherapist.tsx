import React, { FC, useState, useEffect } from 'react';
import axios from 'axios';
import apiService from '../../services/api.service';
import { error } from 'console';


interface ListTherapistProps {}

const ListTherapist: FC<ListTherapistProps> = () => {
  const [listApi, setListApi] = useState<any[]>([])
  useEffect(() => {
    loadItems();
  }, [])

  const loadItems = () => {
    apiService.getListApi().then((res) => {
      console.log(res.data)
      setListApi(res.data)
    })
  }
 
  return <div>
      <h1>Therapist list</h1>
      {listApi.length > 0 ? (
        listApi.map((client) => {
          return <div className='m-4' key={client.Id}>
            <p>{client.id}</p>
            <p>{client.name}</p>
          </div>
        })
      ) : (
        <p>Loading...</p>
      )}
    </div>
}


export default ListTherapist;