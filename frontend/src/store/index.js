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
    updateTweets(state, shittyTweets) {
      state.shittyTweets = shittyTweets;
    },
    addTweet(state, shittyTweet) {
      state.shittyTweets.push(shittyTweet);
    },
  },
  actions: {
    getAllTweetsFromApi({ commit }) {
      axios.get('/api/shittytweets').then(response => commit('updateTweets', response.data));
    },
    postShittyTweet({ commit }, shittyTweet) {
      axios.post('/api/shittytweets', shittyTweet).then(response => commit('addTweet', response.data));
    },
  },
  getters: {
    getAllTweets(state) {
      return state.shittyTweets;
    },
  },
});
