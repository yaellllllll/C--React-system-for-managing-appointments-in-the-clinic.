import React, { FC, useState, useEffect } from 'react';
import apiService from '../../services/api.service';

interface Client {
  Id: number;
  Name: string;
}

const ListApiAxios: FC = () => {
  const [listApi, setListApi] = useState<Client[]>([]);
  const [loaded, setLoaded] = useState<boolean>(false);

  useEffect(() => {
    loadItems();
  }, []);

  const loadItems = async () => {
    try {
      const response = await apiService.getListApi();
      console.log(response.data);
      setListApi(response.data);
    } catch (error) {
      console.error('Error loading clients:', error);
    } finally {
      setLoaded(true);
    }
  };

  return (
    <div>
      {loaded && (
        <div>
          <h1>Clients list</h1>
          {listApi.map((client) => (
            <div className='m-4' key={client.Id}>
              <p>ID: {client.Id}</p>
              <p>Name: {client.Name}</p>
            </div>
          ))}
        </div>
      )}
    </div>
  );
};

export default ListApiAxios;
