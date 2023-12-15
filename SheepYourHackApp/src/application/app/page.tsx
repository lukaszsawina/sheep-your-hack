import { ThemeProvider } from '@mui/material/styles';
import Image from 'next/image'
import { Button } from '@mui/material';

export default async function Home() {

  const res = await fetch('http://localhost:5002/api/echo');
  
  return (
    <div>
      <Button variant="contained">Primary</Button>
      <Button variant="contained" color="secondary" sx={{ ml: 2 }}>Seconday</Button>
    </div>
  )
}
