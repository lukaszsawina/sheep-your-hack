import { Roboto } from 'next/font/google';
import { createTheme } from '@mui/material/styles';
import { lime, purple } from '@mui/material/colors';

const roboto = Roboto({
  weight: ['300', '400', '500', '700'],
  subsets: ['latin'],
  display: 'swap',
});

const secondary = {
  main: '#9cc69b',
  light: '#42a5f5',
  dark: '#1565c0',
  contrastText: '#fff',
};

const primary = {
  main: '#333533',
  light: '#F5EBFF',
  contrastText: '#fff',
};


const theme = createTheme({
  palette: {
    mode: 'light',
    primary: primary,
    secondary: secondary
  },
  typography: {
    fontFamily: roboto.style.fontFamily,
  },
  components: {
    MuiAlert: {
      styleOverrides: {
        root: ({ ownerState }) => ({
          ...(ownerState.severity === 'info' && {
            backgroundColor: '#60a5fa',
          }),
        }),
      },
    },
  },
});

export default theme;