import Vue from 'vue';
import Vuex from 'vuex';
import axios from 'axios';

Vue.use(Vuex);

export default new Vuex.Store({
  state: {
    shittyTweets: [],
    thisShittyTweet: null,
  },
  mutations: {
    setAllTweets(state, shittyTweets) {
      state.shittyTweets = shittyTweets;
    },
  },
  actions: {
    getAllTweetsFromApi(store) {
      axios.get('/api/shittytweets').then(response => store.commit('setAllTweets', response.data));
    },
  },
  getters: {
    getAllTweets(state) {
      return state.shittyTweets;
    },
  },
});
